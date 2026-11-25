document.addEventListener('DOMContentLoaded', () => {
    // 1. تحريك أشرطة المهارات بسلاسة عند تحميل الصفحة
    const progressBars = document.querySelectorAll('.progress');
    setTimeout(() => {
        progressBars.forEach(bar => {
            const targetWidth = bar.getAttribute('data-width');
            bar.style.width = targetWidth;
        });
    }, 300);

    // 2. تبديل العبارات الملهمة الخاصة بنظم المعلومات كل 5 ثوانٍ
    const quotes = [
        '"نُحوّل البيانات الصماء إلى قرارات ذكية تصنع المستقبل."',
        '"نظم المعلومات هي الجسر الذي يربط بين رؤية الإدارة وقوة التكنولوجيا."',
        '"الشغف بالتطوير المستمر هو مفتاح النجاح في عالم التقنية المتسارع."',
        '"تحليل دقيق اليوم يعني نجاحاً مؤسسياً مستداماً غداً."'
    ];

    const quoteElement = document.getElementById('dynamic-quote');
    let currentIndex = 0;

    setInterval(() => {
        quoteElement.style.opacity = 0;
        setTimeout(() => {
            currentIndex = (currentIndex + 1) % quotes.length;
            quoteElement.textContent = quotes[currentIndex];
            quoteElement.style.opacity = 1;
        }, 500);
    }, 5000);

    // 3. زر التبديل بين الوضع النهاري والليلي
    const themeToggleBtn = document.getElementById('theme-toggle');
    const icon = themeToggleBtn.querySelector('i');

    themeToggleBtn.addEventListener('click', () => {
        document.body.classList.toggle('dark-mode');
        if (document.body.classList.contains('dark-mode')) {
            icon.classList.remove('fa-moon');
            icon.classList.add('fa-sun');
        } else {
            icon.classList.remove('fa-sun');
            icon.classList.add('fa-moon');
        }
    });
});