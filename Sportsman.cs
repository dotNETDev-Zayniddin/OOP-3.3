namespace OOP
{
    class Sportsman
    {
       private object[,] boxers = new object[5,5]
       {
        {1, "Ali", "Muhammad", 40, 100},
        {2, "Tyson", "Mike", 35, 108},
        {3, "Lewis", "Lennox", 45, 43},
        {4,"Holyfield", "Evander", 43, 74},
        {5, "Frazier", "Joe", 39, 74}
       };
       
       public void WeightClassification() // Listlar orqali ishlay olmadim. Iteratsiyalar uchun foydalana olmadim listlardan 
       { 
        int j = 1;
        Console.WriteLine("Yengil(50 kg gacha): ");
        for(int i = 0; i < 5; i++)
        {
           if((int)boxers[i,4] < 50)
           {
                Console.WriteLine($"{j}) {boxers[i,1]} {boxers[i,2]} => {boxers[i,4]}");
                j++;
           }
        }
        
        j = 1;
        Console.WriteLine("*************************************************************");
        Console.WriteLine("O’rta(50 dan 76kg gacha): ");
        for(int i = 0; i < 5; i++)
        {
            if((int)boxers[i,4] > 50 && (int)boxers[i,4] < 76)
           {
                Console.WriteLine($"{j}) {boxers[i,1]} {boxers[i,2]} => {boxers[i,4]}");
                j++;
           }
        }

         j = 1;
        Console.WriteLine("*************************************************************");
        Console.WriteLine("Og’ir(90 kg va undan og’irlar): ");
        for(int i = 0; i < 5; i++)
        {
            if((int)boxers[i,4] > 90)
           {
                Console.WriteLine($"{j}) {boxers[i,1]} {boxers[i,2]} => {boxers[i,4]}");
                j++;
           }
        }
       }
    }
}