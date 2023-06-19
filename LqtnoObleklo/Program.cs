namespace LqtnoObleklo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string timeOfDay = Console.ReadLine();
             string Outfit = Console.ReadLine(); 
            string Shoes = Console.ReadLine();
            List<int> gradysiList = new List<int>();
            int n = int.Parse(Console.ReadLine());
            int gradysi;
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Въведи градуси");
                gradysi = int.Parse(Console.ReadLine());
                gradysiList.Add(gradysi);

            }
            for (int i = 0; i < n; i++)
            {
                if (gradysiList[i] >= 10 && gradysiList[i] <= 18)
                {
                    if (timeOfDay == "Сутрин")
                    {
                        Outfit = "Суитчър";
                        Shoes = "Маратонки";
                        Console.WriteLine($"Ако е{gradysiList} градуси, си " +
                            $"облечи{Outfit} и {Shoes}");
                    }
                    else if (timeOfDay == "Обед")
                    {
                        Outfit = "Риза";
                        Shoes = "Мокасини";
                        Console.WriteLine($"Ако е{gradysiList} градуси, си " +
                            $"облечи{Outfit} и {Shoes}");
                    }
                    else if (timeOfDay == "Вечер")
                    {
                        Outfit = "Риза";
                        Shoes = "Мокасини";
                        Console.WriteLine($"Ако е{gradysiList} градуси, си " +
                            $"облечи{Outfit} и {Shoes}");
                    }

                    if (gradysiList[i] < 18 && gradysiList[i] <= 24)
                    {
                        if (timeOfDay == "Сутрин")
                        {
                            Outfit = "Риза";
                            Shoes = "Мокасини";
                            Console.WriteLine($"Ако е{gradysiList} градуси, си " +
                                $"облечи{Outfit} и {Shoes}");
                        }
                        else if (timeOfDay == "Обед")
                        {
                            Outfit = "Тениска";
                            Shoes = "Сандали";
                            Console.WriteLine($"Ако е{gradysiList} градуси, си " +
                                $"облечи{Outfit} и {Shoes}");
                        }
                        else if (timeOfDay == "Вечер")
                        {
                            Outfit = "Риза";
                            Shoes = "Мокасини";
                            Console.WriteLine($"Ако е{gradysiList} градуси, си " +
                                $"облечи{Outfit} и {Shoes}");
                        }
                    }

                    if (gradysiList[i]>=25)
                    {
                        if (timeOfDay == "Сутрин")
                        {
                            
                            Console.WriteLine($"Ако е{gradysiList} градуси, си " +
                                $"облечи{Outfit} и {Shoes}");
                        }
                        else if (timeOfDay == "Обед")
                        {
                            Outfit = "Бански";
                            Shoes = "С боси крака  ";
                            Console.WriteLine($"Ако е{gradysiList} градуси, си " +
                                $"облечи{Outfit} и {Shoes}");
                        }
                        else if (timeOfDay == "Вечер")
                        {
                            Outfit = "Риза";
                            Shoes = "Мокасини";
                            Console.WriteLine($"Ако е{gradysiList} градуси, си " +
                                $"облечи{Outfit} и {Shoes}");
                        }
                    }
                }
            }
        }
    }
}
    
