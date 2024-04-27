<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="content.aspx.cs" Inherits="WebTruyen.DetailView.content" %>

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

        <p>Trong lúc vô tình hắn phát hiện, thế giới võ cấp cao học sinh đạt được hắn chỉ điểm tu luyện có thành tựu về sau, liền có thể trả lại cho Cố Cửu Thanh chính mình!</p>

        <p>Thế giới võ cấp cao, 1 vị Võ Tổ ra đời.</p>

        <p>"Cao võ nguyên niên, Võ Tổ truyền xuống Long Tượng Công, Long Tượng Công trở thành liên bang bộ thứ nhất tập thể dục theo đài."</p>

        <p>"Đồng niên, Võ Tổ sáng lập kiếm đạo, truyền xuống Trảm Thiên Bạt Kiếm Thuật!"</p>

        <p>"Cao võ 3 năm, Võ Tổ truyền xuống Đại Hoang Vu Kiếm Quyết!"</p>

        <p>"Cao võ năm thứ mười, liên bang đệ nhất cường giả bạch nhật phi thăng!"</p>

        <p>...</p>

        <p>Cố Cửu Thanh chậm rãi mở mắt ra, ở trong cơ thể hắn, hội tụ 4 tỷ võ giả Long Tượng Công lực lượng, tuỳ tiện ở giữa liền có thể xé rách hư không.</p>

        <p>Hội tụ hơn trăm triệu kiếm đạo học sinh đối rút kiếm thuật tu vi, chỉ là tiết lộ ra ngoài một tia kiếm khí liền có thể chặt đứt càn khôn.</p>

        <p>Bên ngoài tẩm cung, Đại Hoang kiếm môn chưởng giáo rất cung kính đứng thẳng.</p>

        <p>"Đệ tử cầu kiến thái thượng trưởng lão, Đại Hoang dã thần tràn lan, còn xin thái thượng cầm kiếm quét sạch chư thần!"</p>

        <p>Dã thần tràn lan?</p>

        <p>Cố Cửu Thanh nhìn xem cao võ hành tinh xanh, đó là từng tôn tu luyện thành thần người, không khỏi nghi ngờ.</p>

        <p>Cao võ ức vạn thần minh, cái kia tựa hồ càng thêm tràn lan a.</p>

        <p>Mà hắn càng là trở thành một tôn Tổ Thần!</p>
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
