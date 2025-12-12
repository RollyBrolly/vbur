<?php
include 'db_connect.php';

$studentID = $_GET['student_id'] ?? null;
$student = null;

if ($studentID) {
    $stmt = $conn->prepare("SELECT * FROM student WHERE StudentID = ?");
    $stmt->bind_param("s", $studentID);
    $stmt->execute();
    $result = $stmt->get_result();
    $student = $result->fetch_assoc();
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
<meta charset="UTF-8">
<title>Praxis - Dashboard</title>
<link href="https://fonts.googleapis.com/css2?family=Roboto:wght@300;400;700&display=swap" rel="stylesheet">
<link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0/css/all.min.css">
<style>
body {
            font-family: 'Roboto', sans-serif;
            margin: 0;
            padding: 0;
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
        
        .hero {
            background: white;
            max-width: 900px;      
            margin: 250px auto 80px auto;    
            padding: 50px 40px;    
            border-radius: 15px;
            box-shadow: 0 0 25px rgba(0,0,0,0.15); 
            text-align: center;
        }
        .hero h1 {
            font-size: 80px;
            margin-bottom: 10px;
            color: #6d25b1;
            font-weight: 700;
        }
        .hero p {
            font-size: 30px;
            margin-bottom: 40px;
            max-width: 600px;
            margin-left: auto;
            margin-right: auto;
        }
        .hero h3 {
            color: #6d25b1;
            margin-bottom: 20px;
        }
        .hero .description {
            font-size: 18px;
            margin-bottom: 30px;
        }
        .hero .links {
            display: flex;
            justify-content: center;
            gap: 20px;
            flex-wrap: wrap;
        }
        .hero a {
            text-decoration: none;
            color: white;
            background: #6d25b1;
            padding: 12px 25px;
            border-radius: 5px;
            font-weight: 500;
            transition: background 0.3s;
        }
        .hero a:hover {
            background: #a561ff;
        }
        footer {
            background: #6d25b1;
            color: white;
            text-align: center;
            padding: 10px;
            margin-top: 50px;
        }
        @media (max-width: 768px) {
            .nav-logo {
                display: none; 
            }
            nav ul {
                padding-left: 0; 
                flex-direction: column;
                gap: 15px;
            }
            nav li {
                margin: 0;
            }
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
    <img src="websitelogo.png" class="nav-logo">
    <ul>
        <li><a href="index.php?student_id=<?php echo $studentID; ?>">Home</a></li>
        <li><a href="gradeslip.php?student_id=<?php echo $studentID; ?>">Grade Slip</a></li>
        <li><a href="sumrep.php?student_id=<?php echo $studentID; ?>">Summary Report</a></li>
    </ul>
</nav>

<section class="hero">
    <h1>WELCOME</h1>
    <p>Hello, <?php echo $student ? $student['StudentFirstName'] : 'Student'; ?>!</p>
    <h3>Access Your OJT Documents</h3>
    <p class="description">View and download your official grade slip or summary report.</p>
    <div class="links">
        <a href="gradeslip.php?student_id=<?php echo $studentID; ?>">Grade Slip</a>
        <a href="sumrep.php?student_id=<?php echo $studentID; ?>">Summary Report</a>
    </div>
</section>

<footer>
    <p>&copy; 2025 Praxis State University. All rights reserved.</p>
</footer>
</body>
</html>
