:root {
    --primary-color: #2b5876;
    --secondary-color: #4e4376;
    --accent-color: #00a896;
    --bg-gradient: linear-gradient(135deg, #f0f4f8 0%, #d9e2ec 100%);
    --card-bg: rgba(255, 255, 255, 0.92);
    --text-main: #1f2933;
    --text-muted: #52606d;
    --border-color: rgba(43, 88, 118, 0.12);
    --shadow: 0 10px 30px rgba(0, 0, 0, 0.06);
}

/* ألوان الوضع الليلي */
body.dark-mode {
    --primary-color: #64dfdf;
    --secondary-color: #80ffdb;
    --accent-color: #00b4d8;
    --bg-gradient: linear-gradient(135deg, #0f172a 0%, #1e293b 100%);
    --card-bg: rgba(30, 41, 59, 0.9);
    --text-main: #f8fafc;
    --text-muted: #cbd5e1;
    --border-color: rgba(255, 255, 255, 0.1);
    --shadow: 0 10px 30px rgba(0, 0, 0, 0.3);
}

* {
    box-sizing: border-box;
    margin: 0;
    padding: 0;
}

body {
    font-family: 'Tajawal', sans-serif;
    background: var(--bg-gradient);
    color: var(--text-main);
    line-height: 1.7;
    min-height: 100vh;
    padding: 30px 15px;
    transition: all 0.4s ease;
    position: relative;
    overflow-x: hidden;
}

/* أشكال الخلفية المتناسقة */
.bg-shapes .shape {
    position: fixed;
    border-radius: 50%;
    filter: blur(80px);
    z-index: -1;
    opacity: 0.4;
}

.shape-1 {
    width: 350px;
    height: 350px;
    background: #00a896;
    top: -100px;
    right: -100px;
}

.shape-2 {
    width: 400px;
    height: 400px;
    background: #4e4376;
    bottom: -150px;
    left: -100px;
}

.container {
    max-width: 1050px;
    margin: 0 auto;
}

/* الترويسة */
.profile-header {
    background: var(--card-bg);
    backdrop-filter: blur(10px);
    border-radius: 20px;
    padding: 35px;
    text-align: center;
    box-shadow: var(--shadow);
    border: 1px solid var(--border-color);
    margin-bottom: 25px;
    position: relative;
}

.header-actions {
    position: absolute;
    top: 20px;
    left: 20px;
    display: flex;
    gap: 10px;
}

.icon-btn, .print-btn {
    background: var(--primary-color);
    color: #fff;
    border: none;
    padding: 8px 15px;
    border-radius: 10px;
    cursor: pointer;
    font-family: 'Tajawal', sans-serif;
    font-size: 0.9rem;
    transition: transform 0.2s, opacity 0.2s;
}

body.dark-mode .icon-btn, 
body.dark-mode .print-btn {
    color: #0f172a;
    font-weight: bold;
}

.icon-btn:hover, .print-btn:hover {
    transform: translateY(-2px);
    opacity: 0.9;
}

.avatar {
    width: 90px;
    height: 90px;
    margin: 0 auto 15px;
    background: linear-gradient(135deg, var(--primary-color), var(--accent-color));
    color: #fff;
    border-radius: 50%;
    display: flex;
    align-items: center;
    justify-content: center;
    font-size: 2.5rem;
    box-shadow: 0 8px 20px rgba(0, 168, 150, 0.3);
}

.profile-info h1 {
    font-size: 2.3rem;
    font-weight: 800;
    color: var(--primary-color);
}

.subtitle {
    font-size: 1.2rem;
    font-weight: 500;
    color: var(--accent-color);
    margin-bottom: 10px;
}

.quote {
    font-style: italic;
    color: var(--text-muted);
    max-width: 600px;
    margin: 10px auto 20px;
    font-size: 1.05rem;
    transition: opacity 0.5s ease;
}

.contact-links {
    display: flex;
    flex-wrap: wrap;
    justify-content: center;
    gap: 20px;
    font-size: 0.95rem;
    color: var(--text-muted);
}

.contact-links span, .contact-links a {
    display: flex;
    align-items: center;
    gap: 7px;
    text-decoration: none;
    color: inherit;
}

.contact-links i {
    color: var(--accent-color);
}

/* شبكة المحتوى */
.cv-grid {
    display: grid;
    grid-template-columns: 1.4fr 1fr;
    gap: 25px;
}

.card {
    background: var(--card-bg);
    backdrop-filter: blur(10px);
    border-radius: 18px;
    padding: 25px;
    box-shadow: var(--shadow);
    border: 1px solid var(--border-color);
    margin-bottom: 25px;
    transition: transform 0.3s ease;
}

.card:hover {
    transform: translateY(-4px);
}

.section-title {
    font-size: 1.3rem;
    color: var(--primary-color);
    margin-bottom: 18px;
    padding-bottom: 10px;
    border-bottom: 2px solid var(--border-color);
    display: flex;
    align-items: center;
    gap: 10px;
}

.section-title i {
    color: var(--accent-color);
}

.about-text {
    color: var(--text-muted);
    text-align: justify;
}

/* الخط الزمني للمؤهلات والخبرات */
.timeline-item {
    position: relative;
    padding-right: 18px;
    border-right: 2px solid var(--accent-color);
    margin-bottom: 20px;
}

.timeline-item:last-child {
    margin-bottom: 0;
}

.timeline-item h4 {
    font-size: 1.1rem;
    color: var(--text-main);
}

.timeline-item .date {
    display: inline-block;
    font-size: 0.85rem;
    color: var(--accent-color);
    font-weight: 700;
    margin: 3px 0;
}

.timeline-item .institution {
    font-weight: 500;
    font-size: 0.95rem;
    color: var(--primary-color);
}

.timeline-item .desc {
    font-size: 0.95rem;
    color: var(--text-muted);
    margin-top: 5px;
}

/* أشرطة المهارات */
.skill-item {
    margin-bottom: 15px;
}

.skill-info {
    display: flex;
    justify-content: space-between;
    font-size: 0.95rem;
    font-weight: 500;
    margin-bottom: 5px;
}

.progress-bar {
    width: 100%;
    height: 9px;
    background: rgba(0, 0, 0, 0.08);
    border-radius: 10px;
    overflow: hidden;
}

body.dark-mode .progress-bar {
    background: rgba(255, 255, 255, 0.1);
}

.progress {
    height: 100%;
    width: 0;
    background: linear-gradient(90deg, var(--primary-color), var(--accent-color));
    border-radius: 10px;
    transition: width 1.2s ease-in-out;
}

/* وسوم المهارات الشخصية */
.tags-container {
    display: flex;
    flex-wrap: wrap;
    gap: 10px;
}

.tag {
    background: rgba(0, 168, 150, 0.12);
    color: var(--primary-color);
    padding: 6px 14px;
    border-radius: 20px;
    font-size: 0.9rem;
    font-weight: 600;
    border: 1px solid rgba(0, 168, 150, 0.25);
}

.lang-list {
    list-style: none;
    color: var(--text-muted);
}

.lang-list li {
    margin-bottom: 8px;
}

/* بطاقة العبارة الملهمة */
.quote-card {
    background: linear-gradient(135deg, var(--primary-color), var(--secondary-color));
    color: #fff;
    text-align: center;
}

body.dark-mode .quote-card {
    color: #0f172a;
}

.quote-icon {
    font-size: 1.5rem;
    opacity: 0.7;
    margin-bottom: 8px;
}

/* التجاوب مع الجوال والطباعة */
@media (max-width: 768px) {
    .cv-grid {
        grid-template-columns: 1fr;
    }
    .header-actions {
        position: static;
        justify-content: center;
        margin-bottom: 15px;
    }
}

@media print {
    body {
        background: #fff;
        padding: 0;
    }
    .header-actions, .bg-shapes {
        display: none;
    }
    .card, .profile-header {
        box-shadow: none;
        border: 1px solid #ddd;
    }
}