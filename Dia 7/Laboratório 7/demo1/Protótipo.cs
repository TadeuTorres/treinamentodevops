
            var numbers = new List<int>();
            var random = new Random();

            while(numbers.Count < 6)
            {
                var number = random.Next(1, 60);
                numbers.Add(number);
            }

            numbers.ForEach(n => Console.WriteLine($"{n} "));

            Console.ReadLine();
