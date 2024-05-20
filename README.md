<h1>Training to Interview</h1>


<h2>Constraints</h2>
**Constraints (cheklovlar)** — bu ma'lumotlar bazasidagi ma'lumotlarning yaxlitligi va to'g'riligini ta'minlash uchun ishlatiladigan qoidalar. Masalan, `PRIMARY KEY`, `FOREIGN KEY`, `UNIQUE`, `NOT NULL`, va `CHECK` kabi cheklovlar mavjud.

Misol qilib ketiradigan bosek:
```csharp
public class Product
{
    [Key]
    public int ProductId { get; set; }

    [Required]
    [MaxLength(100)]
    public string Name { get; set; }

    [ForeignKey("Category")]
    public int CategoryId { get; set; }

    public Category Category { get; set; }
}
```

<h2>LINQ</h2>
LINQ (Language Integrated Query) — bu .NET tilida yozilgan kod orqali ma'lumotlarni so'rov qilish va manipulyatsiya qilish imkonini beruvchi texnologiya. LINQ ma'lumotlar bazalari, XML hujjatlar, kollektsiyalar va boshqa manbalardan ma'lumotlarni olish uchun ishlatiladi.

Misol uchun:
```csharp
List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var evenNumbers = from number in numbers
                  where number % 2 == 0
                  select number;

foreach (var num in evenNumbers)
{
    Console.WriteLine(num);
}
```
bu misolda list ichidagi sonlarni LINQ yordamida sortlamoqdamiz

<h2>Stack Trace</h2>
**Stack Trace (stack izini)** — bu dasturda xatolik yuz berganida, qaysi metodlar qaysi qatorlarda chaqirilganini ko'rsatib beradigan ro'yxat. Bu dasturchiga xatolikni topish va tuzatishga yordam beradi.

<h2>Stack va Queue</h2>
Stack (stack) — bu ma'lumotlarni LIFO (Last In, First Out — oxirgi kirgan, birinchi chiqadi) tamoyili asosida saqlaydigan ma'lumotlar tuzilmasi.

Misol uchun:
```csharp
Stack<int> stack = new Stack<int>();
stack.Push(1);
stack.Push(2);
stack.Push(3);

Console.WriteLine(stack.Pop()); // 3
Console.WriteLine(stack.Pop()); // 2
```
Queue (queue) — bu ma'lumotlarni FIFO (First In, First Out — birinchi kirgan, birinchi chiqadi) tamoyili asosida saqlaydigan ma'lumotlar tuzilmasi.

Misol:
```csharp
Queue<int> queue = new Queue<int>();
queue.Enqueue(1);
queue.Enqueue(2);
queue.Enqueue(3);

Console.WriteLine(queue.Dequeue()); // 1
Console.WriteLine(queue.Dequeue()); // 2
```
<h2>Try Catch</h2>
Try-Catch — bu dasturda xatoliklar yuz berganda ularni tutish va qayta ishlash uchun ishlatiladigan konstruktsiya. `try` blokida xatolik yuz berishi mumkin bo'lgan kod yoziladi, `catch` blokida esa ushbu xatolikni tutish va unga munosabat bildirish uchun kod yoziladi.

Misol:
```csharp
try
{
    int a = 10;
    int b = 0;
    int result = a / b;
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("Xato: " + ex.Message);
}
```

<h2>SQL</h2>
SQL (Structured Query Language) — bu ma'lumotlar bazalarini boshqarish va ulardagi ma'lumotlarni olish uchun ishlatiladigan maxsus til. SQL yordamida ma'lumotlarni kiritish, yangilash, o'chirish va so'rov qilish mumkin.

Oddiy misol:
```sql
SELECT * FROM Products WHERE Price > 100;
```

<h2>Trigger</h2>
Trigger — bu ma'lumotlar bazasidagi biror hodisa yuz berganda (masalan, jadvalga yozuv qo'shilganda yoki o'chirilganda) avtomatik ravishda ishga tushadigan dastur kodi.

Misol uchun:

```sql
CREATE TRIGGER trgAfterInsert
ON Products
FOR INSERT
AS
BEGIN
    PRINT 'Product added!'
END
```

<h2>Composite Key</h2>
Composite Key (kompozit kalit) — bu bir nechta ustun birgalikda jadvalning biror yozuvini noyob tarzda aniqlash uchun ishlatiladigan birlashma kalit.

Misol:
```csharp
public class OrderDetail
{
    [Key, Column(Order = 0)]
    public int OrderId { get; set; }

    [Key, Column(Order = 1)]
    public int ProductId { get; set; }
}
```
<h2>Cache Aside</h2>
Cache Aside — bu kesh va asosiy ma'lumotlar bazasini sinxronizatsiya qilish uchun ishlatiladigan usul. Dastur birinchi navbatda keshdan ma'lumotni qidiradi, agar u yerda topmasa, asosiy bazadan olib, keyin keshlaydi.

<h2>Mediator Notifications</h2>
Mediator Notifications — bu Mediator dizayn andozasida ishlatiladigan mexanizm bo'lib, turli komponentlar o'rtasida xabar almashinuvi va hamkorlikni tashkil qiladi.

<h2>Func Methodlar Nechta</h2>
Func metodlar — bu .NET ecosystemda ishlatiladigan vakil turlari bo'lib, ular bir yoki bir nechta argumentni qabul qiladi va qiymat qaytaradi. `Func` tipidagi vakillar 0 dan 16 tagacha argument qabul qilishi mumkin.

Misol:
```csharp
Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(3, 4)); // 7
```
<h2>Database Indexes</h2>
Database Indexes (ma'lumotlar bazasi indekslari) — bu jadvaldagi qatorlarni tezkor qidirish va tartiblash uchun ishlatiladigan ma'lumotlar tuzilmasi. Indekslar so'rovlarning bajarilish tezligini oshiradi.

Misol:
```sql
CREATE INDEX idx_product_name ON Products (ProductName);
```

<h2>Design Patterns and Indexes</h2>
Design Patterns — bu dasturiy ta'minot muammolarini samarali hal qilish uchun ko'p marta ishlatiladigan yechimlar to'plami. Dizayn patternlari va indekslar birgalikda ishlatilganda, ma'lumotlar bazasi operatsiyalarini optimallashtirish mumkin.

<h2>SQL Joins</h2>
SQL Joins — bu bir nechta jadvallardagi ma'lumotlarni birlashtirish uchun ishlatiladigan SQL amallari. `INNER JOIN`, `LEFT JOIN`, `RIGHT JOIN`, va `FULL JOIN` kabi turli xil birlashtirishlar mavjud.

Inner Joinga misol keltiradigan bolsak:
```sql
SELECT Orders.OrderID, Customers.CustomerName
FROM Orders
INNER JOIN Customers ON Orders.CustomerID = Customers.CustomerID;
```

<h2>Views</h2>
Views — bu SQL so'rovlari natijalarini saqlash va qayta ishlatish uchun yaratilgan virtual jadvallar. Ko'rinishlar jadvallarni qayta-qayta yozmasdan ulardan ma'lumotlarni olish imkonini beradi.

Misol uchun:
```sql
CREATE VIEW ProductView AS
SELECT ProductName, Price FROM Products WHERE Price > 100;
```

<h2>Why We Need Views</h2>
Nega Bizga Viewlar Kerak — ko'rinishlar ma'lumotlar bazasida xavfsizlikni oshirish, kodni soddalashtirish va so'rovlarni qayta ishlatishni ta'minlash uchun kerak.

<h2>Foreign Key</h2>
Foreign Key — bu bir jadvaldagi ustunning boshqa jadvaldagi biror ustunga bog'langanligini ko'rsatuvchi kalit. Tashqi kalitlar jadvallar o'rtasidagi bog'lanishni va ma'lumotlarning yaxlitligini ta'minlaydi.

Misol:
```csharp
public class Order
{
    [Key]
    public int OrderId { get; set; }

    [ForeignKey("Customer")]
    public int CustomerId { get; set; }
    
    public Customer Customer { get; set; }
}
```
Explanation: bu yerda C# tilida qanday qilib foreign key qilish haqida misol keltirilgan.

