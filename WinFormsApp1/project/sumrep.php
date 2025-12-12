<?php
include 'db_connect.php'; // database connection

$studentID = $_GET['student_id'] ?? null;

if (!$studentID) {
    die("Student ID not specified.");
}

// Fetch student + grades + supervisor
$studentQuery = $conn->prepare("
    SELECT 
        s.StudentID,
        s.StudentFirstName, s.StudentMiddleName, s.StudentLastName, s.Suffix,
        s.StudentEmail, s.StudentContactNo,
        c.CourseName,
        s.Section,
        d.DeptName,
        sv.Question1, sv.Question2, sv.Question3, sv.Question4, sv.Question5,
        sv.Question6, sv.Question7, sv.Question8, sv.Question9, sv.Question10,
        sv.TotalPoints, sv.Rating,
        sup.SupervisorFirstName AS SupFirstName,
        sup.MiddleName AS SupMiddleName,
        sup.SupervisorLastName AS SupLastName,
        sup.Suffix AS SupSuffix,
        sup.SupervisorPosition
    FROM student s
    LEFT JOIN course c ON s.CourseID = c.CourseID
    LEFT JOIN department d ON c.DepartmentID = d.DepartmentID
    LEFT JOIN studentevaluations sv ON s.StudentID = sv.StudentID
    LEFT JOIN supervisor sup ON sv.SupervisorID = sup.SupervisorID
    WHERE s.StudentID = ?
    LIMIT 1
");

if (!$studentQuery) {
    die("Prepare failed: " . $conn->error);
}

$studentQuery->bind_param("s", $studentID);

if (!$studentQuery->execute()) {
    die("Execute failed: " . $studentQuery->error);
}

$result = $studentQuery->get_result();

if (!$result) {
    die("Getting result failed: " . $studentQuery->error);
}

$student = $result->fetch_assoc();

if (!$student) {
    die("Student not found.");
}

// ----------------------------
// Helper Functions
// ----------------------------
function fullName($first, $middle, $last, $suffix) {
    $name = $first;
    if (!empty($middle)) $name .= " $middle";
    $name .= " $last";
    if (!empty($suffix)) $name .= " $suffix";
    return $name;
}

function getCourseInitials($courseName) {
    $words = explode(' ', $courseName);
    $ignore = ['of', 'in', 'and', 'the', 'for'];
    $initials = '';

    foreach ($words as $word) {
        if (!in_array(strtolower($word), $ignore) && strlen($word) > 0) {
            $initials .= strtoupper($word[0]);
        }
    }
    return $initials;
}

function getDeptInitials($deptName) {
    $words = explode(' ', $deptName);
    $ignore = ['of', 'in', 'and', 'the', 'for'];
    $initials = '';

    foreach ($words as $word) {
        if (!in_array(strtolower($word), $ignore) && strlen($word) > 0) {
            $initials .= strtoupper($word[0]);
        }
    }
    return $initials;
}

function scoreToRemark($score) {
    switch ($score) {
        case 5: return "Outstanding (O)";
        case 4: return "Very Satisfactory (VS)";
        case 3: return "Satisfactory (S)";
        case 2: return "Needs Improvement (NI)";
        case 1: return "Unacceptable (U)";
        default: return "N/A";
    }
}
?>

<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<title>Summary Report</title>
<link rel="stylesheet" href="sumrep.css">

</head>
<body>
<style>    
    body {
        font-family: 'Roboto', sans-serif;
        margin: 40px;
        background: #f7f7f7;
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


    .page {
        position: relative;
        width: 800px;
        margin: auto;
        margin-top: 230px;
        border-radius: 1%;
        padding: 40px;
        background: white;
        border: 1px solid #ccc;
        text-align: center;
        overflow: hidden; 
        }

    .header {
        text-align: center;
        margin-bottom: 20px;
        position: relative;
        }

    .header img {
        width: 130px;
        position: absolute;
        left: 0;
        top: 0;
        }

            .watermark {
            position: absolute;
            top: 52%;          
            left: 50%;
            width: 75%;        
            max-width: 700px;  
            opacity: 0.12;     
            transform: translate(-50%, -50%);
            pointer-events: none;
            z-index: 0;
        }
    


    .title {
        margin-top: 10px;
    }

    .info-section {
        margin-top: 20px;
        font-size: 17px;
        line-height: 1.8;
    }

    .info-row {
        display: flex;
        justify-content: space-between;
        margin-bottom: 10px;
    }

    .info-row span {
        flex: 1;
    }

    h3 {
        margin-top: 20px;
        text-decoration: underline;
    }

    table {
        width: 100%;
        border-collapse: collapse;
        margin-top: 15px;
        font-size: 16px;
        margin: 0 auto; 
    }

    th, td {
        border: 1px solid black;
        padding: 8px;
        text-align: center;
    }

    .criteria {
        text-align: left;
    }

    .comments-section {
        margin-top: 30px;
        font-size: 17px;
        text-align: left;
        line-height: 1.8;
    }

    .comments-section h3 {
        text-decoration: underline;
        margin-bottom: 10px;
    }

    .blank-line {
        font-family: monospace;
        white-space: pre-wrap;
        margin: 10px 0;
    }

    .evaluated-by {
        margin-top: 20px;
    }

    .signature-line, .position-line {
        border-bottom: 1px solid black;
        width: 300px;
        margin: 5px 0;  
        display: inline-block;
    }

    .total {
        margin-top: 30px;
        font-size: 17px;
        font-weight: bold;
        display: flex;
        justify-content: space-around;
        align-items: center;
    }

    .signatories {
        margin-top: 20px;
        font-size: 17px;
        display: flex;
        justify-content: space-around;
        align-items: flex-start; 
    }

    .signatories div {
        flex: 1;
        text-align: center; 
    }</style>
<div class="page">

    <img src="uni logo.png" class="watermark">
    <nav>
        <img src="websitelogo.png" alt="University Logo" class="nav-logo">
        <ul>
            <li><a href="index.php?student_id=<?php echo $studentID; ?>">Home</a></li>
            <li><a href="gradeslip.php?student_id=<?php echo $studentID; ?>">Grade Slip</a></li>
            <li><a href="sumrep.php?student_id=<?php echo $studentID; ?>">Summary Report</a></li>
        </ul>
    </nav>

    <div class="header">
        <h3>Republic of the Philippines</h3>
        <h2 class="title">PRAXIS STATE UNIVERSITY</h2>
        <div>

            <img src="uni logo.png" alt="University Logo">
            PSU Pasig Campus, Kapasigan, Pasig<br>
            ☎ (046) 437-9505 | psu.pasig@gmail.com | www.psu-pasig.edu.ph
        </div>
        <h3>SUMMARY REPORT<br>(On the Job Training)</h3>
    </div>

    <div class="info-section">
        <div class="info-row">
            <span><b>Name of Student:</b> <?php echo fullName($student['StudentFirstName'], $student['StudentMiddleName'], $student['StudentLastName'], $student['Suffix']); ?></span>
            <span><b>Student Number:</b> <?php echo $student['StudentID']; ?></span>
        </div>
        <div class="info-row">
            <span><b>Program & Section:</b> <?php echo getCourseInitials($student['CourseName']) . ' - ' . $student['Section']; ?></span>
            <span><b>Department:</b> <?php echo getDeptInitials($student['DeptName']); ?></span>
        </div>
        <div class="info-row">
            <span><b>Mobile No:</b> <?php echo $student['StudentContactNo']; ?></span>
            <span><b>Email:</b> <?php echo $student['StudentEmail']; ?></span>
        </div>
    </div>

    <h3>Performance Summary</h3>

    <table>
        <tr>
            <th>CRITERIA</th>
            <th>SCORE</th>
            <th>REMARKS</th>
        </tr>

        <tr>
            <td class="criteria">1. Attendance & Punctuality</td>
            <td><?php echo $student['Question1']; ?></td>
            <td><?= scoreToRemark($student['Question1']); ?></td>
        </tr>

        <tr>
            <td class="criteria">2. Workplace Grooming</td>
            <td><?php echo $student['Question2']; ?></td>
            <td><?= scoreToRemark($student['Question2']); ?></td>
        </tr>

        <tr>
            <td class="criteria">3. Communication Skills</td>
            <td><?php echo $student['Question3']; ?></td>
            <td><?= scoreToRemark($student['Question3']); ?></td>
        </tr>

        <tr>
            <td class="criteria">4. Listening & Responsiveness</td>
            <td><?php echo $student['Question4']; ?></td>
            <td><?= scoreToRemark($student['Question4']); ?></td>
        </tr>

        <tr>
            <td class="criteria">5. Work Interest</td>
            <td><?php echo $student['Question5']; ?></td>
            <td><?= scoreToRemark($student['Question5']); ?></td>
        </tr>

        <tr>
            <td class="criteria">6. Skill Development</td>
            <td><?php echo $student['Question6']; ?></td>
            <td><?= scoreToRemark($student['Question6']); ?></td>
        </tr>

        <tr>
            <td class="criteria">7. Workstation Orderliness</td>
            <td><?php echo $student['Question7']; ?></td>
            <td><?= scoreToRemark($student['Question7']); ?></td>
        </tr>

        <tr>
            <td class="criteria">8. Report Accuracy</td>
            <td><?php echo $student['Question8']; ?></td>
            <td><?= scoreToRemark($student['Question8']); ?></td>
        </tr>

        <tr>
            <td class="criteria">9. Knowledge of Duties</td>
            <td><?php echo $student['Question9']; ?></td>
            <td><?= scoreToRemark($student['Question9']); ?></td>
        </tr>

        <tr>
            <td class="criteria">10. Growth & Development</td>
            <td><?php echo $student['Question10']; ?></td>
            <td><?= scoreToRemark($student['Question10']); ?></td>
        </tr>
    </table>

    <div class="total">
        <div>TOTAL POINTS: <?php echo $student['TotalPoints']; ?></div>
        <div>EQUIVALENT RATING: <?php echo $student['Rating']; ?></div>
    </div>
    <div class="signatories">
        <div>
            <p>Evaluated by:</p>
            <div class="signature-line"> <?php echo fullName($student['SupFirstName'], $student['SupMiddleName'], $student['SupLastName'], $student['SupSuffix']); ?></div>
            <p style="font-style: italic;">Signature over Printed Name</p>
        </div>
        <div>
            <p>Position/ Designation</p>
            <div class="position-line"> <?php echo $student['SupervisorPosition']; ?></div>
        </div>
    </div>

</div>

</body>
</html>