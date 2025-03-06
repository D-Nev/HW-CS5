namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

        }

        //1
        static int Range(int start, int end)
        {
            int a = 1;
            for (int i = start; i <= end; i++)
            {
                a *= i;
            }
            return a;
        }

        //2
        static bool Fibonachi(int num)
        {
            int a = 0, b = 1, tmp;
            while (b < num)
            {
                tmp = a + b;
                a = b;
                b = tmp;
            }
            return b == num || num == 0;
        }

        //3
        static void Sort(int[] arr, bool asc)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if ((asc && arr[i] > arr[j]) || (!asc && arr[i] < arr[j]))
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }

        //4
        class City
        {
            public string Name { get; set; }
            public string Country { get; set; }
            public int Popultn { get; set; }
            public string PhoneCode { get; set; }
            public string Streetnum { get; set; }

            public void DisplayInfo()
            {
                Console.WriteLine($"Город: {Name}, Страна: {Country}, Население: {Popultn}, Код: {PhoneCode}, Район: {Streetnum}");
            }
        }


        //5
        class Sotrudnik
        {
            public string Name { get; set; }
            public DateTime BirthDate { get; set; }
            public string Phone { get; set; }
            public string Email { get; set; }
            public string Position { get; set; }
            public string Doljnost { get; set; }

            public void DisplayInfo()
            {
                Console.WriteLine($"ФИО: {Name}, Дата рождения: {BirthDate.ToShortDateString()}, Телефон: {Phone}, Email: {Email}, Должность: {Position}, Обязанности: {Doljnost}");
            }
        }

        //6
        class Airplane
        {
            public string Name { get; set; }
            public string Proizvoditel { get; set; }
            public int Year { get; set; }
            public string Type { get; set; }

            public Airplane(string name, string proizvod, int year, string type)
            {
                Name = name;
                Proizvoditel = proizvod;
                Year = year;
                Type = type;
            }

            public void DisplayInfo()
            {
                Console.WriteLine($"Название: {Name}, Производитель: {Proizvoditel}, Год выпуска: {Year}, Тип: {Type}");
            }
        }


        //7
        class Matrix
        {
            private int[,] data;
            private int row, cls;
            public Matrix(int row, int cls)
            {
                this.row = row;
                this.cls = cls;
                data = new int[row, cls];
            }
            public void Set(int[,] values)
            {
                data = values;
            }
            public void Display()
            {
                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < cls; j++)
                    {
                        Console.Write(data[i, j] + " ");
                    }
                    Console.WriteLine();
                }
            }
            public int MaxVal()
            {
                int max = data[0, 0];
                foreach (var item in data)
                {
                    if (item > max) max = item;
                }
                return max;
            }
            public int MinVal()
            {
                int min = data[0, 0];
                foreach (var item in data)
                {
                    if (item < min) min = item;
                }
                return min;
            }
        }



    }
}
