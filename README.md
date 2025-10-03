🔄 Loops - C# Loop Examples & Patterns
مجموعه کاملی از مثال‌ها و الگوهای حلقه در زبان C# - مناسب برای یادگیری و آموزش

https://img.shields.io/badge/C%2523-239120?style=for-the-badge&logo=c-sharp&logoColor=white
https://img.shields.io/badge/.NET-512BD4?style=for-the-badge&logo=dotnet&logoColor=white
https://img.shields.io/badge/Education-Loops%2520Tutorial-blue?style=for-the-badge
https://img.shields.io/badge/GitHub-Open%2520Source-181717?style=for-the-badge&logo=github

https://img.shields.io/github/stars/programmerdrn/Loops
https://img.shields.io/github/forks/programmerdrn/Loops
https://img.shields.io/github/issues/programmerdrn/Loops

✨ ویژگی‌ها
✅ انواع حلقه‌های C#: for, while, do-while, foreach

✅ الگوهای کاربردی: مثلث‌ها، اعداد، اشکال مختلف

✅ مثال‌های عملی: از ساده تا پیشرفته

✅ کدهای تمیز و کامنت‌گذاری شده

✅ مناسب برای تمام سطوح: مبتدی تا حرفه‌ای

🏗️ ساختار پروژه
text
Loops/
├── Program.cs                 # فایل اصلی با تمام مثال‌ها
├── Patterns/                  # الگوهای مختلف
│   ├── NumberPatterns.cs     # الگوهای عددی
│   ├── StarPatterns.cs       # الگوهای ستاره‌ای
│   └── ShapePatterns.cs      # الگوهای اشکال
├── Examples/                 # مثال‌های کاربردی
│   ├── BasicLoops.cs         # حلقه‌های پایه
│   └── AdvancedLoops.cs      # حلقه‌های پیشرفته
└── README.md
🚀 نحوه اجرا
پیش‌نیازها
.NET 6.0 یا بالاتر

اجرای پروژه
bash
# کلون کردن ریپوزیتوری
git clone https://github.com/programmerdrn/Loops.git
cd Loops

# اجرای پروژه
dotnet run
📚 انواع حلقه‌های موجود
1. حلقه for
csharp
// چاپ اعداد ۱ تا ۵
for (int i = 1; i <= 5; i++)
{
    Console.WriteLine(i);
}
2. حلقه while
csharp
// چاپ اعداد تا زمانی که شرط برقرار است
int counter = 1;
while (counter <= 5)
{
    Console.WriteLine(counter);
    counter++;
}
3. حلقه do-while
csharp
// حداقل یک بار اجرا می‌شود
int number = 1;
do
{
    Console.WriteLine(number);
    number++;
} while (number <= 5);
4. حلقه foreach
csharp
// پیمایش آرایه‌ها و مجموعه‌ها
string[] names = {"Ali", "Reza", "Sara"};
foreach (string name in names)
{
    Console.WriteLine(name);
}
🎯 الگوهای نمونه
مثلث ستاره‌ای
text
*
**
***
****
*****
مثلث اعداد
text
1
12
123
1234
12345
پیرامید
text
    *
   ***
  *****
 *******
*********
💡 مثال‌های کاربردی
csharp
// محاسبه مجموع اعداد
int sum = 0;
for (int i = 1; i <= 100; i++)
{
    sum += i;
}
Console.WriteLine($"مجموع اعداد ۱ تا ۱۰۰: {sum}");

// پیدا کردن اعداد زوج
for (int i = 1; i <= 20; i++)
{
    if (i % 2 == 0)
    {
        Console.WriteLine($"{i} عدد زوج است");
    }
}
🧪 اجرای تست‌ها
bash
# اجرای تست‌های واحد (اگر موجود باشد)
dotnet test
🎓 کاربردهای آموزشی
✅ مبتدیان: یادگیری مفاهیم پایه حلقه

✅ متوسط: درک الگوریتم‌های پیچیده‌تر

✅ پیشرفته: بهینه‌سازی و الگوهای پیچیده

🤝 مشارکت در توسعه
مشارکت شما باعث کامل‌تر شدن این مجموعه آموزشی می‌شود!

ریپو را Fork کنید

Branch جدید ایجاد کنید (git checkout -b feature/new-pattern)

تغییرات را Commit کنید (git commit -m 'Add new pattern')

Branch را Push کنید (git push origin feature/new-pattern)

Pull Request ایجاد کنید

📄 لایسنس
این پروژه تحت لایسنس MIT منتشر شده است.

👨‍💻 توسعه‌دهنده
programmerdrn - GitHub Profile

⭐ اگر این پروژه آموزشی برایتان مفید بود، حتما به آن Star بدهید!

💬 پشتیبانی و سوالات
📧 ایجاد Issue در گیتهاب

🔄 پیشنهاد الگوهای جدید

برچسب‌ها: csharp dotnet loops patterns educational programming-tutorial learning
