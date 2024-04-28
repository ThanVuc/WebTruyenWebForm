<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Content.aspx.cs" Inherits="WebTruyen.DetailView.content" %>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Tuỳ Kiếm Tiên Thần - Chương 4</title>
    <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/font-awesome/5.15.4/css/all.min.css">
    <style>
        body {
            font-family: Arial, sans-serif;
            background-color: #f8f8f8;
            margin: 0;
            padding: 0;
        }
        .container {
            width: 500%;
            max-width: 1300px;
            margin: 20px auto;
            background-color: hsl(0, 14%, 96%); /* Đổi màu nền thành màu xám */
            border-radius: 8px;
            box-shadow: 0 0 10px rgba(0,0,0,0.1);
            position: relative;
            min-height: 100vh;
        }
        .header {
            padding: 20px;
            background-color: #4CAF50;
            color: white;
            border-top-left-radius: 8px;
            border-top-right-radius: 8px;
        }
        .header h1 {
            margin: 0;
        }
        .content {
            width: 100%; /* Kéo rộng ô nội dung ra hết màn hình */
            padding: 20px;
            line-height: 1.6;
        }
        .footer {
            padding: 20px;
            background-color: #4CAF50;
            color: white;
            border-bottom-left-radius: 8px;
            border-bottom-right-radius: 8px;
        }

        /* Định vị các icon ở góc phải trên màn hình */
        .top-icons {
            position: fixed;
            top: 20px;
            right: 20px;
            z-index: 999; /* Đảm bảo các icon hiển thị trên cùng */
            display: flex;
            flex-direction: column;
        }
        .top-icons i {
            margin-bottom: 10px;
            color: #777; /* Đổi màu icon thành màu xám */
            font-size: 24px;
            cursor: pointer;
        }

        /* Định vị các icon ở góc phải dưới màn hình */
        .bottom-icons {
            position: fixed;
            bottom: 20px;
            right: 20px;
            z-index: 999; /* Đảm bảo các icon hiển thị trên cùng */
            display: flex;
            flex-direction: column;
        }
        .bottom-icons i {
            margin-bottom: 10px;
            color: #777; /* Đổi màu icon thành màu xám */
            font-size: 24px;
            cursor: pointer;
        }
    </style>
</head>
<body>

<div class="container">
    <div class="header">
        <h1>Tuỳ Kiếm Tiên Thần - Chương 4</h1>
    </div>

    <div class="content">
        <p>Đại Hoang kiếm môn đệ tử Cố Cửu Thanh trong giấc mộng, hắn mộng thấy chính mình trở thành thế giới võ cấp cao 1 vị lão sư.</p>
    </div>

    <div class="footer">
        <!-- Không có gì ở đây -->
    </div>
</div>

<!-- Phần icon ở góc phải trên màn hình -->
<div class="top-icons">
    <i class="fas fa-list"></i>
    <i class="fas fa-cog"></i>
    <i class="fas fa-arrow-left"></i>
    <i class="fas fa-exclamation-circle"></i> <!-- Thay đổi từ tam giác thành hình tròn -->
</div>

<!-- Phần icon ở góc phải dưới màn hình -->
<div class="bottom-icons">
    <i class="fas fa-heart"></i>
    <i class="fas fa-save"></i>
    <i class="fas fa-comment"></i>
</div>

</body>
</html>
