// Задача 4. Дан массив средних температур (массив заполняется случайно) 
// за последние 10 лет. На ввод подают номер месяца и год начали и конца.
// Определить самые высокие и низкие температуры для лета, осени, зимы и весны 
// в заданном промежутке. Если таких температур нет, сообщить, что определить не удалось.

    Console.Write("Введите месяц года, за который вы хотите узнать средние температуры: ");
    string mounth = Console.ReadLine(); 
    Console.Write("Введите год, за который вы хотите узнать средние температуры: ");
    int jear =  Convert.ToInt32(Console.ReadLine());  
    int[] temperature = new int[120]; 
    int length = temperature.Length;
    int index = 0;
    int tempindex = (jear - 2012) * 12 - 1; // минус один - потому что расчет начинаем 
                                            // с декабря предыдущего года - начало времени года
    // Console.WriteLine($"Месяц начала расчета {tempindex} от начала наблюдения");     // для проверки

    if(jear < 2012 || jear > 2021) 
    {
        Console.WriteLine("Температуру определить не удалось");
        Environment.Exit(0);
    }
    else
    {
        while (index < length)
        {
            temperature[index] = new Random().Next(1, 35); // Значения температур от +1 до +35 град.
            // Console.Write(temperature[index] + " ");
            index++;    
        }
    }
    Console.WriteLine();

    if(jear == 2012 && mounth.ToLower() == "январь" || jear == 2012 && mounth.ToLower() == "февраль")
    {
        index = tempindex + 1;
        int max1 = temperature[index];
        if(temperature[index + 1] > max1) max1 = temperature[index + 1];        
        Console.WriteLine($"Максимальная температура зимой за данный промежуток времени составляет {max1} градуса (-ов)");
                    
        int min1 = temperature[index];
        if(temperature[index + 1] < min1) min1 = temperature[index + 1];        
        Console.WriteLine($"Минимальная температура зимой за данный промежуток времени составляет {min1} градуса (-ов)");
        Console.WriteLine();
        index = tempindex + 3;
        Vesna();
        index = tempindex + 6;
        Leto();
        index = tempindex + 9;
        Osene();        
    }
    else   
    if(jear == 2021 && mounth.ToLower() == "март" || jear == 2021 && mounth.ToLower() == "апрель" || jear == 2021 && mounth.ToLower() == "май")
    {
        index = tempindex + 3;
        Vesna();
        index = tempindex + 6;
        Leto();
        index = tempindex + 9;
        Osene();
        Console.WriteLine($"Максимальная температура зимой за данный промежуток времени составляет {temperature[119]} градуса (-ов)");
        Console.WriteLine($"Минимальная температура зимой за данный промежуток времени составляет {temperature[119]} градуса (-ов)");        
    }
    else   
    if(jear == 2021 && mounth.ToLower() == "июнь" || jear == 2021 && mounth.ToLower() == "июль" || jear == 2021 && mounth.ToLower() == "август")
    {
        index = tempindex + 6;
        Leto();
        index = tempindex + 9;
        Osene();
        Console.WriteLine($"Максимальная температура зимой за данный промежуток времени составляет {temperature[119]} градуса (-ов)");
        Console.WriteLine($"Минимальная температура зимой за данный промежуток времени составляет {temperature[119]} градуса (-ов)");
        Console.WriteLine("Дальнейшую температуру определить не удалось");
        Console.WriteLine();
    }
    else   
    if(jear == 2021 && mounth.ToLower() == "сентябрь" || jear == 2021 && mounth.ToLower() == "октябрь" || jear == 2021 && mounth.ToLower() == "ноябрь")
    {
        index = tempindex + 9;        
        Osene();
        Console.WriteLine($"Максимальная температура зимой за данный промежуток времени составляет {temperature[119]} градуса (-ов)");
        Console.WriteLine($"Минимальная температура зимой за данный промежуток времени составляет {temperature[119]} градуса (-ов)");
        Console.WriteLine("Дальнейшую температуру определить не удалось");
        Console.WriteLine();
    }
    else   
    if(jear == 2021 && mounth.ToLower() == "декабрь")
    {
        Console.WriteLine($"Максимальная температура зимой за данный промежуток времени составляет {temperature[119]} градуса (-ов)");
        Console.WriteLine($"Минимальная температура зимой за данный промежуток времени составляет {temperature[119]} градуса (-ов)");
        Console.WriteLine("Дальнейшую температуру определить не удалось");
        Console.WriteLine();
    }
    else
    if(mounth.ToLower() == "декабрь") 
    {
        tempindex = (jear - 2012 + 1) * 12 - 1; // + 1 - дальнейший вывод температуры идет по году, который следует за декабрем введенного года
        index = tempindex;        
        Zima();
        index = tempindex + 3;
        Vesna();
        index = tempindex + 6;
        Leto();
        index = tempindex + 9;
        Osene();
    }
    else
    if(jear > 2012 && mounth.ToLower() == "январь" || jear > 2012 && mounth.ToLower() == "февраль") 
    {
        index = tempindex;
        Zima();
        index = tempindex + 3;
        Vesna();
        index = tempindex + 6;
        Leto();
        index = tempindex + 9;
        Osene();
    }
    else   
    if(jear < 2021 && mounth.ToLower() == "март" || jear < 2021 && mounth.ToLower() == "апрель" || jear < 2021 && mounth.ToLower() == "май") 
    {
        index = tempindex + 3;
        Vesna();
        index = tempindex + 6;
        Leto();
        index = tempindex + 9;
        Osene();
        index = tempindex + 12;
        Zima();        
    }
    else
    if(jear < 2021 && mounth.ToLower() == "июнь" || jear < 2021 && mounth.ToLower() == "июль" || jear < 2021 && mounth.ToLower() == "август") 
    {          
        index = tempindex + 6;
        Leto();
        index = tempindex + 9;
        Osene();
        index = tempindex + 12;
        Zima(); 
        index = tempindex + 15;
        Vesna();
    }
    else
    if(jear < 2021 && mounth.ToLower() == "сентябрь" || jear < 2021 && mounth.ToLower() == "октябрь" || jear < 2021 && mounth.ToLower() == "ноябрь") 
    {        
        index = tempindex + 9;
        Osene();
        index = tempindex + 12;
        Zima(); 
        index = tempindex + 15;
        Vesna();
        index = tempindex + 18;
        Leto();
    } 
    else 
    Console.WriteLine("Введен некорректный месяц года");
   
    void Zima() 
    {
        int max1 = temperature[index];
        if(temperature[index + 1] > max1) max1 = temperature[index + 1];
        if(temperature[index + 2] > max1) max1 = temperature[index + 2];  
        Console.WriteLine($"Максимальная температура зимой за данный промежуток времени составляет {max1} градуса (-ов)");
                    
        int min1 = temperature[index];
        if(temperature[index + 1] < min1) min1 = temperature[index + 1];
        if(temperature[index + 2] < min1) min1 = temperature[index + 2];  
        Console.WriteLine($"Минимальная температура зимой за данный промежуток времени составляет {min1} градуса (-ов)");
        Console.WriteLine();
    } 

    void Vesna() 
    {
        int max1 = temperature[index];
        if(temperature[index + 1] > max1) max1 = temperature[index + 1];
        if(temperature[index + 2] > max1) max1 = temperature[index + 2];  
        Console.WriteLine($"Максимальная температура весной за данный промежуток времени составляет {max1} градуса (-ов)");
                    
        int min1 = temperature[index];
        if(temperature[index + 1] < min1) min1 = temperature[index + 1];
        if(temperature[index + 2] < min1) min1 = temperature[index + 2];  
        Console.WriteLine($"Минимальная температура весной за данный промежуток времени составляет {min1} градуса (-ов)");
        Console.WriteLine();
    } 

    void Leto() 
    {
        int max1 = temperature[index];
        if(temperature[index + 1] > max1) max1 = temperature[index + 1];
        if(temperature[index + 2] > max1) max1 = temperature[index + 2];  
        Console.WriteLine($"Максимальная температура летом за данный промежуток времени составляет {max1} градуса (-ов)");
                    
        int min1 = temperature[index];
        if(temperature[index + 1] < min1) min1 = temperature[index + 1];
        if(temperature[index + 2] < min1) min1 = temperature[index + 2];  
        Console.WriteLine($"Минимальная температура летом за данный промежуток времени составляет {min1} градуса (-ов)");
        Console.WriteLine();
    } 

    void Osene() 
    {
        int max1 = temperature[index];
        if(temperature[index + 1] > max1) max1 = temperature[index + 1];
        if(temperature[index + 2] > max1) max1 = temperature[index + 2];  
        Console.WriteLine($"Максимальная температура осенью за данный промежуток времени составляет {max1} градуса (-ов)");
                    
        int min1 = temperature[index];
        if(temperature[index + 1] < min1) min1 = temperature[index + 1];
        if(temperature[index + 2] < min1) min1 = temperature[index + 2];  
        Console.WriteLine($"Минимальная температура осенью за данный промежуток времени составляет {min1} градуса (-ов)");
        Console.WriteLine();
    }  
    
