//*! #1
/*
Console.Write($"Vui long nhap ten cua ban: ");
string name = Console.ReadLine() ?? "";
Console.Write($"Vui long nhap nam sinh cua ban: ");
string year = Console.ReadLine() ?? "1901";
int yearOfBirth;
if (!int.TryParse(year, out yearOfBirth))
{
    yearOfBirth = 1901;
    Console.WriteLine(year);
}

Console.Write($"Vui long nhap luong co cua ban: ");
double salary;
if(!double.TryParse(Console.ReadLine(), out salary))
{
    salary = 0d;
    Console.WriteLine("0");
}


int age = DateTime.Now.Year - yearOfBirth;

Console.WriteLine($"Xin chao {name}, ban {age} tuoi. Lương của bạn là: {salary:N0}$");
*/

//*! #2
/*
List<double> salarys = new List<double>();
double salary;
Console.WriteLine("Nhap so tien luong nhan vien, nhap -1 de thoat:");
while (true)
{
    Console.Write($"Nhap so tien luong nhan vien thu {salarys.Count + 1}: ");
    if (double.TryParse(Console.ReadLine(), out salary))
    {
        if (salary == -1)
        {
            break;
        }
        salarys.Add(salary);
    }
    else
    {
        Console.WriteLine("Khong nhap tien luong!!!");

        break;
    }
}
;

if (salarys.Count > 0)
{
    double sumSalary = 0;
    double highestSalary = 0;

    foreach (var s in salarys)
    {
        sumSalary += s;
        if (s > highestSalary)
        {
            highestSalary = s;
        }
    }

    // Console.WriteLine($"Tong quy luong: {sumSalary:N0}");
    // Console.WriteLine($"Luong trung binh: {(sumSalary / salarys.Count):N0}");
    // Console.WriteLine($"Luong cao nhat: {highestSalary:N0}");

    //Using Linq
    Console.WriteLine($"Tong quy luong: {salarys.Sum():N0}");
    Console.WriteLine($"Luong trung binh: {salarys.Average():N0}");
    Console.WriteLine($"Luong cao nhat: {salarys.Max():N0}");
}
else
{
    Console.WriteLine("Chua co du lieu tien luong");
}
*/


//*! #3
/*
using MyApp.Models;

Employee employee1 = new Employee("Nguyen Van A", 15000);
Employee employee2 = new Employee("Nguyen Van B", 21000);
List<Employee> employees = [employee1, employee2];

for (int i =0; i< employees.Count; i++)
{
    Console.WriteLine($"Luong cua nhan vien {i + 1}: {employees[i].BaseSalary}");
    Console.WriteLine($"Luong thuc nhan cua nhan vien {i + 1} la: {employees[i].GetNetSalary()}");
}
*/

//*! 4

/*
using MyApp.Models;

// Cach khai bao 1
// FullTimeEmployee nv1 = new FullTimeEmployee("NV1", "Nguyen Van A", 15000.5d);
// FullTimeEmployee nv2 = new FullTimeEmployee("NV2", "Nguyen Van ZB", 15500.5d);
// FullTimeEmployee nv3 = new FullTimeEmployee("NV3", "Nguyen Van C", 15090.5d);
// PartTimeEmployee nv4 = new PartTimeEmployee("NV4", "Truong Thi D", 4.5d, 3680.2d);
// PartTimeEmployee nv5 = new PartTimeEmployee("NV5", "Truong Thi F", 7.5d, 3650.4d);
// List<BaseEmployee> employees = [nv1, nv2, nv3, nv4, nv5];

// Cach khai bao 2
// List<BaseEmployee> employees = new List<BaseEmployee>();
// employees.Add(new FullTimeEmployee("NV1", "Nguyen Van A", 15000.5d));
// employees.Add(new FullTimeEmployee("NV2", "Nguyen Van ZB", 15500.5d));
// employees.Add(new FullTimeEmployee("NV3", "Nguyen Van C", 15090.5d));
// employees.Add(new PartTimeEmployee("NV4", "Truong Thi D", 4.5d, 3680.2d));
// employees.Add(new PartTimeEmployee("NV4", "Truong Thi D", 4.5d, 3680.2d));

// Cach khai bao 3
List<BaseEmployee> employees =
[
    new FullTimeEmployee("NV1", "Nguyen Van A", 15000.5d),
    new FullTimeEmployee("NV2", "Nguyen Van ZB", 15500.5d),
    new FullTimeEmployee("NV3", "Nguyen Van C", 15090.5d),
    new PartTimeEmployee("NV4", "Truong Thi D", 4.5d, 3680.2d),
    new PartTimeEmployee("NV4", "Truong Thi D", 4.5d, 3680.2d),
];

foreach (BaseEmployee employee in employees)
{
    Console.WriteLine($"Luong cua nhan vien {employee.Name} la: {employee.CalculateSalary():N2}");
}
*/

//*! D5
/*
using MyApp.Extension;
using MyApp.Utility;

CompanyConfig.PrintHeader();
double salary = 152300d;
Console.WriteLine($"Luong cua ban la: {salary.ToCurrency()}");
*/

//*! Tổng hợp D1 -> D5
/*
using MyApp.Extension;
using MyApp.Interface;
using MyApp.Models;

List<IVehicle> vehicles = [
    new Honda("City"),
    new Honda("Civic"),
    new Honda("HR-V"),
    new Honda("CR-V"),
    new Honda("BR-V"),
    new Honda("Kia"),
    new Honda("Accord")
];

foreach (IVehicle vehicle in vehicles)
{
    vehicle.StartEngine();
    if(vehicle is Car car)
    {
        car.Drive();
        car.PrintInfo();
    }
}
*/

/*
using MyApp.Extension;
using MyApp.Models.D1_D5;

Console.OutputEncoding = System.Text.Encoding.UTF8;
List<Product> cart = new List<Product>();
int autoId = 1; // Tự tăng ID

while (true)
{
    Console.WriteLine("\n--- ORDER MANAGEMENT SYSTEM ---");
    Console.WriteLine("1. Thêm Laptop (Hàng vật lý)");
    Console.WriteLine("2. Thêm Khóa Học (Hàng Digital)");
    Console.WriteLine("3. Xem giỏ hàng");
    Console.WriteLine("4. Thanh toán (Tổng tiền)");
    Console.WriteLine("0. Thoát");
    Console.Write("Chọn chức năng: ");

    string choice = Console.ReadLine();

    switch (choice)
    {
        case "1":
            Console.Write("Nhập tên Laptop: ");
            string n1 = Console.ReadLine();
            Console.Write("Nhập giá: ");
            double p1 = double.Parse(Console.ReadLine());
            Console.Write("Nhập cân nặng (kg): ");
            double w1 = double.Parse(Console.ReadLine());

            // Đa hình: Add PhysicalProduct vào List<Product>
            cart.Add(new PhysicalProduct(autoId++, n1, p1, w1));
            Console.WriteLine("Đã thêm vào giỏ!");
            break;

        case "2":
            Console.Write("Nhập tên Khóa học: ");
            string n2 = Console.ReadLine();
            Console.Write("Nhập giá: ");
            double p2 = double.Parse(Console.ReadLine());
            Console.Write("Nhập Link: ");
            string l2 = Console.ReadLine();

            // Đa hình: Add DigitalProduct vào List<Product>
            cart.Add(new DigitalProduct(autoId++, n2, p2, l2));
            Console.WriteLine("Đã thêm vào giỏ!");
            break;

        case "3":
            Console.WriteLine("\n--- DANH SÁCH GIỎ HÀNG ---");
            foreach (var item in cart)
            {
                // Gọi ShowInfo(). Tự động chạy đúng hàm của con tương ứng
                item.ShowInfo();
            }
            break;

        case "4":
            double grandTotal = 0;
            foreach (var item in cart)
            {
                grandTotal += item.LastPrice();
            }
            Console.WriteLine($"\n>>> TỔNG THANH TOÁN: {grandTotal.ToUSD()}");
            break;

        case "0":
            return; // Thoát chương trình

        default:
            Console.WriteLine("Chọn sai, vui lòng chọn lại.");
            break;
    }
}
*/

/*
using System.Globalization;
using MyApp.Extension;
using MyApp.Utility;

List<string> rawLogs =
    [
        "INFO|2023-10-20 10:00:00|User A logged in",
        "ERROR|2023-10-20 10:05:00|Database connection failed",
        "WARNING|2023-10-20 10:10:00|High memory usage",
        "INFO|2023-10-20 10:15:00|User B logged out"
    ];


// ParseLogs(rawLogs);
// foreach (LogEntry logEntry in CompanyConfig.ParseLogs(rawLogs))
// {
//     if(logEntry.Type == LogEnum.ERROR)
//     {
//         Console.WriteLine($"Cac Error trong log: {logEntry.Message}");
//     }
// }
List<LogEntry> logEntries = new List<LogEntry>();
logEntries = rawLogs.RetrieveLogsWithTime(
DateTime.ParseExact("2023-10-21 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture),
DateTime.ParseExact("2023-10-21 23:59:59", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture));

foreach (var item in logEntries)
{
    Console.WriteLine($"\n{item.Message}");
}
*/

// *! D6
/*
using MyApp.Models;

TicketCounter counter = new TicketCounter();
var id = 1;
while (true)
{
    Console.WriteLine("=== Hệ thống rạp chiều phim Aeon Cinemax ===");
    Console.WriteLine("Hãy chọn 1 trong các option sau");
    Console.WriteLine("1. CheckIn");
    Console.WriteLine("2. Process");
    Console.WriteLine("3. Find History");
    Console.WriteLine("4. Quit");
    Console.Write("Hãy chọn tính năng để tiếp tục: ");
    var option = Console.ReadLine();
    switch (option)
    {
        case "1":
            {
                Console.WriteLine("Vui long nhap ten phim");
                var movieName = Console.ReadLine();
                Ticket ticket = new Ticket(id++, movieName ?? "");
                counter.CheckIn(ticket);

                break;
            }
        case "2":
            counter.Process();
            break;
        case "3":
            {

                Console.Write("Vui lòng nhập mã vé: ");
                int ticketId = int.Parse(Console.ReadLine() ?? "0");
                counter.FindHistory(ticketId);
                break;
            }
        case "4":
            {
                return;
            }
        default:
            {
                Console.WriteLine("\n Tính năng bạn chọn đang không có!!!");
                break;
            }
    }
}
*/

//*! D7
/*
using MyApp.Extension;
using MyApp.Models.D7;

List<Product> products = [
  new Product(1, "Dieu hoa",1000, "Electronics"),
  new Product(2, "Laptop",500, "Electronics"),
  new Product(3, "Tu lanh",2000, "SamSung"),
  new Product(4, "May giat",2500, "LG"),
  new Product(5, "May say",12300, "Toshiba"),
  new Product(6, "Dieu hoa",520, "Misubishi"),
  new Product(7, "Laptop",3500, "Honda"),
  new Product(8, "Tu lanh",4200, "Yamaha"),
  new Product(9, "May giat",30, "Electronics"),
  new Product(10, "May say",12, "Electronics"),
];

var findCategory = products.Where(p => p.Category == "Electronics").Select(p => p.Name).ToList();
Console.WriteLine(string.Join(", ", findCategory));

List<string> names = (from product in products select product.Name).ToList();
Console.WriteLine(string.Join(", ", names));

var firstItem = (from product in products where product.Price > 1000 select product).FirstOrDefault();

Console.WriteLine($"San pham co gia tren 3000$ la {firstItem?.Name} gia {firstItem?.Price}");

IEnumerable<Product> products1 = (from product in products where product.Price < 50 select product).Select(p => new Product(p.ID, p.Name.ToUpper(), p.Price, p.Category)).ToList();

Console.WriteLine(string.Join(", ", products1.Select(p => $"\nSan pham co gia dưới 50$: {p.Name}-{p.Price.ToCurrency()}")));
*/

/*
List<Order> orders =
[
    new ( 1,  "An",   1200, "PAID" ),
    new ( 2,  "Binh",  300,  "NEW"),
    new (3,  "An",    50,   "CANCEL"),
    new (4,  "Cuong", 2200, "PAID"),
    new (5,  "Binh",  1500, "PAID"),
];

var orderPaids = orders.Where(order => order.Status == "PAID");
Console.WriteLine(string.Join(",", orderPaids.Select(order => $"\ndon hang {order.Id} cua khach hang {order.Customer} da {order.Status}")));

var notSamOrder = orders.Select(order => order.Customer).Distinct().ToList();
Console.WriteLine(string.Join(", ", notSamOrder));

var firstOrderThan1000 = orders.Where(o => o.TotalAmount > 1000)?.FirstOrDefault();
Console.WriteLine($"Don hang dau tien co gia tri lon hon 1000 la: {firstOrderThan1000?.Id} - khach hang {firstOrderThan1000?.Customer}");

var discountOrderThan1000 = orders.Where(o => o.TotalAmount > 1000).Select(o => new Order(o.Id, o.Customer, o.TotalAmount * 0.1, o.Status)).ToList();
if (discountOrderThan1000.Count > 0)
{
    Console.WriteLine(string.Join(",", discountOrderThan1000.Select(o => $"{o?.Id}-{o?.Customer}-{o?.TotalAmount}")));
}
*/

//*! D8
/*
using MyApp.Models.D8;
List<OrderD8> orders =
[
    new (1,  "An",   1200000000, "Completed" ),
    new (2,  "Binh",  30000,  "NEW"),
    new (3,  "An",    50,   "CANCEL"),
    new (4,  "Cuong", 22030, "Completed"),
    new (5,  "Binh",  1500, "Completed"),
];

orders.OrderByDescending(order => order.TotalAmount).ToList().ForEach(order => Console.WriteLine($"{order.Id}-{order.CustomerName}-{order.TotalAmount}"));

var hasOrderThan1Bil = orders.Any(order => order.TotalAmount > 1000000000);
string result = hasOrderThan1Bil ? "Co" : "khong";
Console.WriteLine($"Co don hang tren 1 ti khong: {result}");

var allOrderCompleted = orders.All(order => order.Status == "Completed");
string result1 = allOrderCompleted ? "Dung" : "khong";
Console.WriteLine($"Tat ca cac don hang da hoan thanh phai khong: {result1}");

orders.GroupBy(order => order.CustomerName).Select(gOrders => new
{
    Customername = gOrders.Key, //key chinh la CustomerName
    OrderCount = gOrders.Count(), // so don cua moi CustomerName
    TotalSpent = gOrders.Sum(o => o.TotalAmount)
}).ToList().ForEach(order => Console.WriteLine($"{order.Customername}-{order.OrderCount}-{order.TotalSpent}"));
*/

/*
using MyApp.Models.D8;

List<CustomerOrder> orders =
[
    new (1,  "An",   500, true ),
    new (2,  "Binh",  2000, true),
    new (3,  "An",    300,   false),
    new (4,  "Cuong", 1500, true),
    new (5,  "Binh",  700, false),
];

orders.OrderBy(order => order.Amount).ToList().ForEach(order => Console.WriteLine($"{order.CustomerName}-{order.Amount}"));

var hasUnPaid = orders.Any(order => !order.IsPaid);
var result = hasUnPaid ? "Co" : "Khong";
Console.WriteLine($"Co don chua thanh toan? {result}");

var allAmountThan100 = orders.All(order => order.Amount > 100);
var result1 = allAmountThan100 ? "Dung" : "Khong";
Console.WriteLine($"Tat ca cac don deu co gia tri lon hon 100? {result1}");

orders.GroupBy(order => order.CustomerName).Select(ordersGroup => new
{
    CustomerName = ordersGroup.Key,
    TotalAmount = ordersGroup.Sum(order => order.Amount),
    OrderCount = ordersGroup.Count(),
    HasOrderUnpaid = orders.Any(order => !order.IsPaid)
}).ToList().ForEach(order =>
{
    string? hasUnPaid = order.HasOrderUnpaid ? "Co" : "Khong";
    Console.WriteLine($"Name: {order.CustomerName}- So don: {order.OrderCount}- Tong tien: {order.TotalAmount}-Co don chua thanh toan: {hasUnPaid}");
});
*/
/*
using MyApp.Models.D8;

static List<TResult> Analyze<T, TResult>(
    List<T> source,
    Func<T, string> groupKey,
    Func<IGrouping<string, T>, TResult> projector
)
{
    return source.GroupBy(groupKey).Select(projector).ToList();
}
;
List<CustomerOrder> orders =
[
    new (1,  "An",   500, true ),
    new (2,  "Binh",  2000, true),
    new (3,  "An",    300,   false),
    new (4,  "Cuong", 1500, true),
    new (5,  "Binh",  700, false),
];


var result = Analyze(orders, o => o.CustomerName, g => new
{
    CustomerName = g.Key,
    OrderCount = g.Count(),
    TotalAmount = g.Sum(x => x.Amount)
});

Console.WriteLine(
    string.Join(
        "\n",
        result.Select(r =>
            $"{r.CustomerName} | {r.OrderCount} | {r.TotalAmount}"
        )
    )
);
*/

/*
using System.Globalization;
using MyApp.Models.D8;

List<CustomerOrder> orders =
[
    new (1,  "An",   500, true ),
    new (2,  "Binh",  2000, true),
    new (3,  "An",    300,   false),
    new (4,  "Cuong", 1500, true),
    new (5,  "Binh",  700, false),
];

static List<T> MyWhere<T>(
    List<T> source,
    Func<T, bool> predicate
)
{
    List<T> result = new();

    foreach (var item in source)
    {
        if (predicate(item))   // LINQ gọi delegate ở đây
        {
            result.Add(item);
        }
    }

    return result;
}

static List<TResult> MySelect<T, TResult>(
    List<T> source,
    Func<T, TResult> selector
)
{
    List<TResult> result = new();

    foreach (var item in source)
    {
        result.Add(selector(item));// LINQ gọi delegate ở đây
    }

    return result;
}

static Dictionary<TKey, List<T>> MyGroupBy<T, TKey>(
    List<T> source,
    Func<T, TKey> keySelector
)
{
    var dict = new Dictionary<TKey, List<T>>();

    foreach (var item in source)
    {
        var key = keySelector(item);

        if (!dict.ContainsKey(key))
        {
            dict[key] = new List<T>();
        }

        dict[key].Add(item);
    }

    return dict;
}
MyGroupBy(orders, order => order.Id);

static List<TResult> Analyze<T, TKey, TResult>(
    List<T> source,
    Func<T, TKey> keySelector,
    Func<TKey, List<T>, TResult> projector
)
{
    var groups = new Dictionary<TKey, List<T>>();

    foreach (var item in source)
    {
        var key = keySelector(item);

        if (!groups.ContainsKey(key))
        {
            groups[key] = new List<T>();
        }

        groups[key].Add(item);
    }

    var result = new List<TResult>();

    foreach (var pair in groups)
    {
        result.Add(projector(pair.Key, pair.Value));
    }

    return result;
}


Analyze(orders, order => order.Id, (id, orders) =>
{
    Dictionary<int, List<CustomerOrder>> newDic = new Dictionary<int, List<CustomerOrder>>();
    newDic[id] = orders;
    return newDic;
});

List<OrderLinq> orderLinqs =
[
    new("Hoang A", 125003, DateTime.ParseExact("2023-10-21 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)),
    new("Nguyen B", 12003, DateTime.ParseExact("2023-10-21 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)),
    new("Hoang A", 12503, DateTime.ParseExact("2023-10-21 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)),
    new("Truong D", 25003, DateTime.ParseExact("2023-10-21 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)),
    new("Truong D", 12500, DateTime.ParseExact("2023-10-21 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)),
    new("Hoang A", 15003, DateTime.ParseExact("2023-10-21 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)),
    new("Le Quang D", 1203, DateTime.ParseExact("2023-10-21 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)),
    new("Tu D", 1250, DateTime.ParseExact("2023-10-21 00:00:00", "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture)),
    ];

List<TResult> Statics<T, TResult>(List<T> source, Func<T, string> groupKey, Func<IGrouping<string, T>, TResult> projector)
{
    return source.GroupBy(groupKey).Select(projector).ToList();
}

Statics(orderLinqs, order => order.Customer, g => new
{
    TotalAmount = g.Sum(o => o.Amount),
    BiggestOrder = g.Max(o => o.Amount),
    CountOrderThan100 = g.Count(o => o.Amount > 1000)
}).ForEach(order => Console.WriteLine(string.Join("\n", $"{order.TotalAmount} | {order.BiggestOrder} | {order.CountOrderThan100}")));
*/

/*
using MyApp.Models.D8;

List<OrderNoLinq> orders = new()
{
    new OrderNoLinq(1, "An", 500),
    new OrderNoLinq(2, "Binh", 2000),
    new OrderNoLinq(3, "An", 300),
    new OrderNoLinq(4, "Cuong", 1500),
    new OrderNoLinq(5, "Binh", 700),
};

static List<TResult> MyGroupSelect<T, TKey, TResult>(
    List<T> source,
    Func<T, TKey> keySelector,
    Func<TKey, List<T>, TResult> projector
)
{
    var groupKey = new Dictionary<TKey, List<T>>();

    foreach (var item in source)
    {
        TKey key = keySelector(item);
        if (!groupKey.ContainsKey(key))
        {
            groupKey[key] = new List<T>();
        }
        groupKey[key].Add(item);
    }

    var newList = new List<TResult>();
    foreach (var pair in groupKey)
    {
        var order = projector(pair.Key, pair.Value);
        newList.Add(order);
    }

    return newList;
}

var filterData = MyGroupSelect(orders, o => o.Customer, (key, gOrders) =>
new
{
    CustomerName = key,
    OrderCount = gOrders.Count,
    TotalAmount = gOrders.Sum(o => o.Amount)
}

);

foreach (var item in filterData)
{
    Console.WriteLine($"{item.CustomerName} | {item.OrderCount} đơn | Tổng tiền: {item.TotalAmount}");
}
*/

//*! D9
/*
using System.Diagnostics;

async Task GetDataA()
{

    await Task.Delay(3000);
}

async Task GetDataBAsync()
{
    await Task.Delay(2000);
}

async Task GetDataCAsync()
{
    await Task.Delay(1000);

}

var stopWatch = Stopwatch.StartNew();

await GetDataA();
await GetDataBAsync();
await GetDataCAsync();
stopWatch.Stop();
Console.WriteLine($"Thoi gian chay 3 func: {stopWatch.ElapsedMilliseconds}");

stopWatch = Stopwatch.StartNew();
await Task.WhenAll(Task.Run(GetDataA), Task.Run(GetDataBAsync), Task.Run(GetDataCAsync));
stopWatch.Stop();
Console.WriteLine($"Thoi gian chay 3 func async await: {stopWatch.ElapsedMilliseconds}");
*/

//*! D10
/*
using MyApp.Models.D10;

List<Task> tasks = new List<Task>();
List<BankAccount> bankAccounts = [
    new (10000)
];
for (int i = 0; i < 100; i++)
{
    int taskId = i; // Tạo biến cục bộ cho closure
    tasks.Add(Task.Run(() => bankAccounts[0].WithDraw(100)));
}

// Đợi tất cả 10 tasks hoàn thành
await Task.WhenAll(tasks);

Console.WriteLine($"So du: {bankAccounts[0].GetBalance()}");

int total = 0;

Parallel.For(0, 1000, i =>
{
    Interlocked.Increment(ref total);
});

Console.WriteLine(total);
*/

/*
using System.Diagnostics;

async Task A() => await Task.Delay(3000);
async Task B() => await Task.Delay(2000);
async Task C() => await Task.Delay(1000);

var sc = Stopwatch.StartNew();
await Task.WhenAll(Task.Run(A), Task.Run(B), Task.Run(C));
sc.Stop();
Console.WriteLine(sc.ElapsedMilliseconds);
*/


//*! D11
//CustomerService customerService = new CustomerService(new Logger(), new Repository());
//customerService.GetInfo();

//DIContainer.SetModule<ILogger, FileLogger>();

using MyApp.Implement;
using MyApp.Interface;

DIContainer.SetModule<ILogger, ConsoleLogger>();
DIContainer.SetModule<IRepository, Repository>();

DIContainer.SetModule<CustomerService, CustomerService>();

var customerService = DIContainer.GetModule<CustomerService>();
customerService.GetInfo();

public class DIContainer
{
    //Dictionary để chứa các interface và module tương ứng
    private static readonly Dictionary<Type, object>
               ResgisteredModules = new Dictionary<Type, object>();

    //Hai hàm cơ bản, ở đây mình chuyển <T> thành 
    //dạng Type trong C# để dễ viết code
    public static void SetModule<TInterface, TModule>()
    {
        SetModule(typeof(TInterface), typeof(TModule));
    }

    public static T GetModule<T>()
    {
        return (T)GetModule(typeof(T));
    }


    private static void SetModule(Type interfaceType, Type moduleType)
    {
        //Kiểm tra module đã implement interface chưa
        if (!interfaceType.IsAssignableFrom(moduleType))
        {
            throw new Exception("Wrong Module type");
        }

        //Tìm constructor đầu tiên
        var firstConstructor = moduleType.GetConstructors()[0];
        object module = null;
        //Nếu như không có tham số
        if (!firstConstructor.GetParameters().Any())
        {
            //Khởi tạo module
            module = firstConstructor.Invoke(null); // new Repository(), new FileLogger()
        }
        else
        {
            //Lấy các tham số của constructor
            var constructorParameters = firstConstructor.GetParameters(); //IRepository, ILogger

            var moduleDependecies = new List<object>();
            foreach (var parameter in constructorParameters)
            {
                var dependency = GetModule(parameter.ParameterType); //Lấy module tương ứng từ DIContainer
                moduleDependecies.Add(dependency);
            }

            //Inject các dependency vào constructor của module
            module = firstConstructor.Invoke(moduleDependecies.ToArray());
        }
        //Lưu trữ interface và module tương ứng
        ResgisteredModules.Add(interfaceType, module);
    }

    private static object GetModule(Type interfaceType)
    {
        if (ResgisteredModules.ContainsKey(interfaceType))
        {
            return ResgisteredModules[interfaceType];
        }
        throw new Exception("Module not register");
    }
}