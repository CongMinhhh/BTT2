using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTT2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Car> cars = new List<Car>()
            {
                new Car("Mazda", "Mazda 5", 1989, 200000, "Đỏ"),
                new Car("Mercedes", "GLC 300", 2003, 210000, "Vàng"),
                new Car("Mustang", "GT Premium Fastback", 2021, 95000, "Trắng"),
                new Car("Ford", "Everest", 2020, 165000, "Đen"),
                new Car("Mercedes", "C 200", 1988, 125000, "Đen"),
            };

            List<Truck> trucks = new List<Truck>()
            {
                new Truck("Daehan Motor", "Teraco 350", 2018, 315000, 7500),
                new Truck("Isuzu", "Forward VM", 2014, 285000, 8000),
                new Truck("Nissan", "Nissan Cabstar NS200", 2021, 265000, 9000),
                new Truck("Daewoo", "Daewoo Gentra", 2020, 235000, 8500),

            };

            int choice;

            do
            {

                Console.WriteLine("------------------------------");
                Console.WriteLine("Chọn loại phương tiện bạn muốn xem:");
                Console.WriteLine("1. Xe ô tô (Car)");
                Console.WriteLine("2. Xe tải (Truck)");
                Console.WriteLine("0. Thoát");
                Console.WriteLine("------------------------------\n");

                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        foreach (var car in cars)
                        {
                            Console.WriteLine(car.ToString());
                        }
                        // Chọn chức năng cho xe ô tô
                        int carChoice;

                        do
                        {
                            Console.WriteLine("\n------------------------------");
                            Console.WriteLine("Chọn chức năng cho xe ô tô:");
                            Console.WriteLine("1. Hiển thị các xe có giá trong khoảng 100.000 đến 250.000");
                            Console.WriteLine("2. Hiển thị các xe có năm sản xuất > 1990");
                            Console.WriteLine("3. Gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm");
                            Console.WriteLine("0. Thoát");
                            Console.WriteLine("------------------------------\n");

                            carChoice = int.Parse(Console.ReadLine());

                            switch (carChoice)
                            {
                                case 1:
                                    // Hiển thị các xe có giá trong khoảng 100.000 đến 250.000
                                    var filteredCars = cars.Where(car => car.Price >= 100000 && car.Price <= 250000);

                                    foreach (var car in filteredCars)
                                    {
                                        Console.WriteLine(car);
                                    }
                                    break;
                                case 2:
                                    // Hiển thị các xe có năm sản xuất > 1990
                                    var carsAfter1990 = cars.Where(car => car.Year > 1990);

                                    foreach (var car in carsAfter1990)
                                    {
                                        Console.WriteLine(car);
                                    }
                                    break;
                                case 3:
                                    // Gom các xe theo hãng sản xuất, tính tổng giá trị theo nhóm
                                    var groupedCars = cars.GroupBy(car => car.Make);

                                    foreach (var group in groupedCars)
                                    {
                                        Console.WriteLine($"Hãng: {group.Key}");
                                        Console.WriteLine($"Tổng giá trị: {group.Sum(car => car.Price)}");
                                    }
                                    break;
                                case 0:
                                    // Thoát
                                    break;
                                default:
                                    Console.WriteLine("Lựa chọn không hợp lệ!");
                                    break;
                            }
                        } while (carChoice != 0);
                        break;
                    case 2:
                        foreach (var truck in trucks)
                        {
                            Console.WriteLine(truck);
                        }
                        // Chọn chức năng cho xe tải
                        int truckChoice;

                        do
                        {
                            Console.WriteLine("\n------------------------------");
                            Console.WriteLine("Chọn chức năng cho xe tải:");
                            Console.WriteLine("1. Hiển thị danh sách 'Truck' theo thứ tự năm sản xuất mới nhất");
                            Console.WriteLine("2. Hiển thị tên các công ty chủ quản của xe tải");
                            Console.WriteLine("0. Thoát");
                            Console.WriteLine("------------------------------\n");

                            truckChoice = int.Parse(Console.ReadLine());

                            switch (truckChoice)
                            {
                                case 1:
                                    // Hiển thị danh sách Truck theo thứ tự năm sản xuất mới nhất
                                    var sortedTrucks = trucks.OrderByDescending(truck => truck.Year);

                                    foreach (var truck in sortedTrucks)
                                    {
                                        Console.WriteLine(truck);
                                    }
                                    break;
                                case 2:
                                    // Hiển thị công ty chủ quản của Truck
                                    foreach (var truck in trucks)
                                    {
                                        Console.WriteLine($"Công ty chủ quản: {truck.Make}");
                                    }
                                    break;
                                case 0:
                                    // Thoát
                                    break;
                                default:
                                    Console.WriteLine("Lựa chọn không hợp lệ!");
                                    break;
                            }
                        } while (truckChoice != 0);
                        break;
                    case 0:
                        // Thoát
                        break;
                    default:
                        Console.WriteLine("Lựa chọn không hợp lệ!");
                        break;
                }
            } while (choice != 0);


        }
    }
}
