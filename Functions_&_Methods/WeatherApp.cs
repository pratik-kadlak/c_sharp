using System;

public class WeatherApp {
    
    public static double calcAvgTemp(int[] temp){
        int n = temp.Length;
        double sum = 0;
        for(int i = 0; i < n; i++){
            sum += temp[i];
        }
        return sum/n;
    }
    
    public static void calcMinMaxTemp(int[] temp, out int min, out int max){
        min = temp[0]; 
        max = temp[0];
        int n = temp.Length;
        for(int i = 1; i < n; i++){
            if(temp[i] < min) min = temp[i];
            if(temp[i] > max) max = temp[i];
        }
    }
    
    public static string calcCommonWeather(string[] weather, string[] pred){
        int n = pred.Length;
        int k = weather.Length;
        int ans = -1;
        int mxCnt = 0;
        
        for(int i = 0; i < k; i++){
            int cur = 0;
            for(int j = 0; j < n; j++){
                if(pred[j] == weather[i]) cur++;
            }
            if(cur > mxCnt){
                mxCnt = cur;
                ans = i;
            }
        }
        return weather[ans];
    }
    
    public static void Main(string[] args){
        Console.WriteLine("Enter the no of days to simulate weather: ");
        int n = int.Parse(Console.ReadLine());
        
        string[] weather = {"sunny", "rainy", "windy", "snowy"};
        string[] pred = new string[n];
        int[] temp = new int[n];
        
        Random rand = new Random();
        
        for(int i = 0; i < n; i++){
            int index = rand.Next(0, weather.Length);
            pred[i] = weather[index];
            temp[i] = rand.Next(-10, 40);
            Console.WriteLine($"Weather On Day {i+1} is {pred[i]}");
        }
        
        int min, max;
        calcMinMaxTemp(temp, out min, out max);
        
        Console.WriteLine($"Avg Temp Of Next {n} days: {calcAvgTemp(temp)}");
        Console.WriteLine($"The min temp of {n} days: {min}");
        Console.WriteLine($"The max temp of {n} days: {max}");
        Console.WriteLine($"Most Common Weather: {calcCommonWeather(weather, pred)}");
    }
    
}