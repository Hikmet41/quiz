        string[] questions = {
            "Azərbaycanın paytaxtı hansı şəhərdir?",
            "Zərdab rayonunun mərkəzi şəhəri hansıdır?",
            "Dünyada ən uzun çay hansıdır?",
            "Azərbaycanın ən böyük gölü hansıdır?",
            "Kimya elementlərinin simvolu cədvəldə necə qeyd olunur?",
            "Türkiyənin ən uzun dənizi hansıdır?",
            "Amerika Qitəsinin ən uzun çayı hansıdır?",
            "Bir insanın ən çox hansı orqanı işləyir?",
            "Ağacların yaşıl hissəsi nəyə deyilir?",
            "Azərbaycanın ən uzun dağı hansıdır?"
        };

        string[][] answers = {
            new string[] { "a) Bakı", "b) Gəncə", "c) Naxçıvan" },
            new string[] { "a) Gəncə", "b) Naxçıvan", "c) Bakı" },
            new string[] { "a) Nil", "b) Amazonka", "c) Kongo" },
            new string[] { "a) Gəncə", "b) Balıqgöl", "c) Sarısu" },
            new string[] { "a) K", "b) H", "c) Fe" },
            new string[] { "a) Akdeniz", "b) Marmara", "c) Karadeniz" },
            new string[] { "a) Misisipi", "b) Hudson", "c) Amur" },
            new string[] { "a) Qan dövran sistemi", "b) Beyin", "c) Qaraciyər" },
            new string[] { "a) Xlorofil", "b) Karotin", "c) Melanin" },
            new string[] { "a) Bazardüzü", "b) Şahdağ", "c) Tufandag" }
        };

        int[] correctAnswers = { 0, 1, 0, 1, 2, 2, 0, 1, 0, 1 };

        int score = 0;
        Random rand = new Random();

        Console.WriteLine("İmtahan başladır!");

        for (int i = 0; i < questions.Length; i++)
        {
            Console.WriteLine($"Sual {i + 1}: {questions[i]}");

            string[] shuffledAnswers = ShuffleArray(answers[i], rand);

            for (int j = 0; j < shuffledAnswers.Length; j++)
            {
                Console.WriteLine(shuffledAnswers[j]);
            }

            Console.Write("Cavabınızı seçin (a/b/c): ");
            char userAnswer = Char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            int userChoice = userAnswer switch
            {
                'a' => 0,
                'b' => 1,
                'c' => 2,
                _ => -1
            };

            if (userChoice == correctAnswers[i])
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Düzgün cavab!");
                score += 10;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Səhv cavab!");
            }

            Console.ResetColor();
            Console.WriteLine();
            if (i < questions.Length - 1)
            {
                Console.WriteLine("Növbəti suala keçmək üçün ENTER düyməsini basın");
                Console.ReadLine();
            }
        }

        Console.WriteLine($"İmtahan bitmişdir! Topladığınız xal: {Math.Max(score, 0)}");
    

    static string[] ShuffleArray(string[] array, Random rand)
    {
        string[] shuffledArray = array.Clone() as string[];
        int n = shuffledArray.Length;
        while (n > 1)
        {
            n--;
            int k = rand.Next(n + 1);
            string value = shuffledArray[k];
            shuffledArray[k] = shuffledArray[n];
            shuffledArray[n] = value;
        }
        return shuffledArray;
    }

