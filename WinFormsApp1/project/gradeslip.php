<?php
include 'db_connect.php'; // your database connection

$studentID = $_GET['student_id'] ?? null;

if (!$studentID) {
    die("Student ID not specified.");
}

// Fetch student info
$studentQuery = $conn->prepare("
    SELECT 
        s.StudentID, s.StudentFirstName, s.StudentMiddleName, s.StudentLastName, s.Suffix,
        c.CourseName, s.Section,
        i.StartDate, i.EndDate, comp.CompanyName,
        sg.GWA, sg.Remarks,
        f.FacultyFirstName AS FacultyFirstName, f.MiddleName AS FacultyMiddleName, f.FacultyLastName AS FacultyLastName, f.Suffix AS FacultySuffix,
        sup.SupervisorFirstName AS SupFirstName, sup.MiddleName AS SupMiddleName, sup.SupervisorLastName AS SupLastName, sup.Suffix AS SupSuffix, sup.SupervisorPosition
    FROM student s
    LEFT JOIN course c ON s.CourseID = c.CourseID
    LEFT JOIN internships i ON s.StudentID = i.StudentID
    LEFT JOIN company comp ON i.CompanyID = comp.CompanyID
    LEFT JOIN studentgrades sg ON s.StudentID = sg.StudentID
    LEFT JOIN faculty f ON f.FacultyID = sg.GradedByFacultyID
    LEFT JOIN supervisor sup ON sup.CompanyID = i.CompanyID
    WHERE s.StudentID = ?
    LIMIT 1
");

$studentQuery->bind_param("s", $studentID);
$studentQuery->execute();
$result = $studentQuery->get_result();
$student = $result->fetch_assoc();

if (!$student) {
    die("Student not found.");
}

// Helper function for full name
function fullName($first, $middle, $last, $suffix) {
    $name = $first;
    if ($middle) $name .= " $middle";
    $name .= " $last";
    if ($suffix) $name .= " $suffix";
    return $name;
}

function getCourseInitials($courseName) {
    $words = explode(' ', $courseName);
    $ignore = ['of', 'in', 'and', 'the', 'for'];
    $initials = '';

    foreach ($words as $word) {
        if (!in_array(strtolower($word), $ignore)) {
            $initials .= strtoupper($word[0]);
        }
    }
    return $initials;
}

?>  
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>Grade Slip</title>
    <link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;700&display=swap" rel="stylesheet">
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css">
    
    <style>
        body {
            display: flex;
            flex-direction: column;
            min-height: 100vh; 
            font-family: 'Roboto', sans-serif;
            background: #f2f2f2;
            padding: 20px;
            margin: 0;
            color: #333;
            line-height: 1.6;
        }
        body::before {
            content: "";
            position: fixed;
            top: 0;
            left: 0;
            width: 100%;
            height: 100%;
            background-image: url("regisformsBG_bw.png");
            background-size: cover;
            background-position: center;
            filter: blur(6px);
            opacity: 0.75;
            z-index: -1;
        }

        nav {
            background: linear-gradient(to bottom, #6d25b1 0%, #500092 100%);
            padding: 50px 0;
            position: fixed;
            top: 0;
            left: 0px;
            width: 100%;
            z-index: 10;
            box-shadow: 0 4px 15px rgba(109, 37, 177, 0.3);
            border-bottom-left-radius: 10px;
            border-bottom-right-radius: 10px;
        }
        .nav-logo {
            height: 150px;
            position: absolute;
            left: 20px;
            top: 50%;
            transform: translateY(-50%);
            transition: opacity 0.3s ease;
        }
        .nav-logo:hover {
            opacity: 0.8;
        }
        nav ul {
            list-style: none;
            display: flex;
            justify-content: center;
            margin: 0;
            padding: 0 0 0 80px; 
        }
        nav li {
            margin: 0 25px;
        }
        nav a {
            color: white;
            font-size: 30px;
            text-decoration: none;
            font-weight: 600;
            text-transform: uppercase;
            letter-spacing: 1px;
            transition: all 0.3s ease;
            padding: 8px 12px;
            border-radius: 5px;
        }
        nav a:hover {
            color: #ffffff;
            transform: scale(1.05);
            background: rgb(51, 0, 99);
        }
        
        .container {
            position: relative;
            padding-top: 120px; 
            width: 850px;
            background: white;
            margin-top: 200px;
            margin-left: 500px;
            padding: 30px;
            border: 1px solid #ccc;
            overflow: hidden;
            border-radius: 15px;
            box-shadow: 0 0 25px rgba(0,0,0,0.15);
        }
        .logo {
            width: 130px;
            position: absolute;
            top: 20px;
            left: 20px;
        }
        .watermark {
            position: absolute;
            width: 600px;
            opacity: 0.15;   
            top: 50%;
            left: 50%;
            transform: translate(-50%, -50%);
            pointer-events: none;
        }
        .header {
            text-align: center;
            margin-top: 40px;
        }
        .info-grid {
            margin: 10px 0; 
            display: grid;
            grid-template-columns: 1fr 1fr;
            row-gap: 10px;
        }
        
        .info-grid label {
            font-weight: bold;
        }
        .grades {
            width: 100%;
            border-collapse: collapse;
        }
        .grades th, .grades td {
            border: 1px solid black;
            padding: 8px;
            text-align: center;
        }
        .cert-text {
            margin: 25px 0;
            line-height: 1.5;
            position: relative;
            z-index: 2;
        }
        .signature-row {
            display: flex;
            justify-content: space-between;
            margin-top: 40px;
        }
        .sig-col {
            width: 45%;
            text-align: center;
        }
        .sig-line {
            border-bottom: 1px solid black;
            margin: 40px 0 5px 0;
        }
        .sig-label {
            font-size: 12px;
            font-style: italic;
        }

        /*.links {
            margin-top: 30px;
            display: flex;
            justify-content: center;
            gap: 20px;
        }

        .links a {
             text-decoration: none;
            color: white;
            background: #6d25b1;
            padding: 12px 25px;
            border-radius: 5px;
            font-weight: 500;
            transition: background 0.3s;
        }

        .links a:hover {
            background: #a561ff;
        }
        */

        @media (max-width: 768px) {
            .hero h1 {
                font-size: 36px;
            }
            .hero .links {
                flex-direction: column;
                gap: 15px;
            }
        }
    </style>
</head>
<body>

        <nav>
        <img src="websitelogo.png" alt="University Logo" class="nav-logo">
        <ul>
            <li><a href="index.php?student_id=<?php echo $studentID; ?>">Home</a></li>
            <li><a href="gradeslip.php?student_id=<?php echo $studentID; ?>">Grade Slip</a></li>
            <li><a href="sumrep.php?student_id=<?php echo $studentID; ?>">Summary Report</a></li>
        </ul>
    </nav>
    <div class="container">
        <img src="uni logo.png" class="watermark">
        <div class="header">
            <img src="uni logo.png" class="logo" alt="University Logo">
            <h2>Praxis State University</h2>
            <h3>On-The-Job Training Grade Slip</h3>
        </div>
        <div class="info-grid">
            <div><label>Student No:</label> <span id="studentNo"> <?php echo $student['StudentID']; ?> </span></div>
            <div><label>Company Assigned:</label> <span id="company"> <?php echo $student['CompanyName']; ?> </span> </div>
            <div><label>Name:</label> <span id="name"> <?php echo fullName($student['StudentFirstName'], $student['StudentMiddleName'], $student['StudentLastName'], $student['Suffix']); ?> </span> </div>
            <div><label>Training Period:</label> <span id="period"> <?php echo $student['StartDate'] . " to " . $student['EndDate']; ?> </span> </div>
            <div><label>Course, Year & Section:</label> <span id="course"> <?php echo getCourseInitials($student['CourseName']) . ' - ' . $student['Section']; ?> </span> </div>
        </div>
        <table class="grades">
            <tr>
                <th>Course Description</th>
                <th>Overall Grades</th>
                <th>Remarks</th>
            </tr>
            <tr>
                <td>On-the-Job Training</td>
                <td id="grade"> <?php echo $student['GWA']; ?> </td>
                <td id="remarks"> <?php echo $student['Remarks']; ?> </td>
            </tr>
        </table>
        <p class="cert-text">
            This certifies that the above student has successfully completed the On-The-Job
            Training (OJT) and the grades presented accurately reflect their performance
            during the training period.
        </p>
        <div class="signature-row">
            <div class="sig-col">
                <strong>Supervisor:</strong><br><br>
                <div class="sig-line"> <?php echo fullName($student['SupFirstName'], $student['SupMiddleName'], $student['SupLastName'], $student['SupSuffix']); ?> </div>
                <p class="sig-label">Signature Over Printed Name</p>
            </div>
            <div class="sig-col">
                <strong>Faculty Coordinator:</strong><br><br>
                <div class="sig-line"> <?php echo fullName($student['FacultyFirstName'], $student['FacultyMiddleName'], $student['FacultyLastName'], $student['FacultySuffix']); ?> </div>
                <p class="sig-label" >Signature Over Printed Name</p>
            </div>
        </div>
        <!--incase na kailangan ibalik-->
        <!---<div class="links">
        <a href="index.html">Home</a>
        <a href="sumrep.html">Summary Report</a>--->
    </div>
    
   
    

    <script src="script.js"></script>
</body>
</html>