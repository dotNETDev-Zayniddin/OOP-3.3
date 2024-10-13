/*
3.Vazifa
Bokschilar ro’yhati berilgan: bokschining Id, familiyasi, ismi, yoshi va vazni.
Yengil(50 kg gacha), O’rta(50 dan 76kg gacha) va og’ir(90 kg va undan og’irlar) vaznli boxchilarni saralab chiqarib beruvchi dastur tuzilsin.
Ma’lumotlar bazasi sifatida list yoki arraydan foydalanishingiz mumkin.
*/
using System;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportsman boxers = new Sportsman();
            boxers.WeightClassification();
            
        }
    }
}