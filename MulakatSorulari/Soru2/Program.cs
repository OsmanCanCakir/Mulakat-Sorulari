using System;

public class Solution
{
    public int MaksimumKar(int[] prices, int buyDay)
    {
        int maxProfit = 0;
        int minPrice = prices[buyDay];
        int sellDay = 0;

        for (int i = buyDay + 1; i < prices.Length; i++)
        {
            if (prices[i] - minPrice > maxProfit)
            {
                maxProfit = prices[i] - minPrice;
                sellDay = i;
            }
        }
        //İndeks karşılığı gün karşılığına dönüştür.
        Console.WriteLine("En iyi satış günü: " + (sellDay + 1));
        return maxProfit;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        bool exit = false;
        while(!exit)
        {
            Console.WriteLine("Lütfen hisse senedi fiyatlarını giriniz... (virgülle ayırarak):");
            string input = Console.ReadLine();
            string[] priceStrings = input.Split(',');
            int[] prices = new int[priceStrings.Length];

            for (int i = 0; i < priceStrings.Length; i++)
            {
                int price;
                if (int.TryParse(priceStrings[i], out price))
                {
                    prices[i] = price;
                }
                else
                {
                    Console.WriteLine("Geçersiz giriş! Lütfen tamsayı değerleri girin.");
                    return;
                }
            }

            Console.WriteLine("Alım yapılacak günü giriniz:");
            int buyDay;
            if (!int.TryParse(Console.ReadLine(), out buyDay) || buyDay < 1 || buyDay >= prices.Length)
            {
                Console.WriteLine("Hatalı giriş! Lütfen geçerli bir gün indeksi girin.");
                return;
            }
            //1. gün 0. indekse karşılık gelecek
            buyDay--;
            Solution solution = new Solution();
            int maxProfit = solution.MaksimumKar(prices, buyDay);

            Console.WriteLine("Maksimum kar: " + maxProfit);
            Console.WriteLine("Devam etmek için bir tuşa basın veya 'Q' tuşuna basarak çıkın...");

            ConsoleKeyInfo keyInfo = Console.ReadKey();
            if (keyInfo.KeyChar == 'q' || keyInfo.KeyChar == 'Q')
            {
                exit = true;
            }
        }
        
    }
}