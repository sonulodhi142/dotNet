using System;

class Dog{

    public string DogName = "";
    public void sound(){
        Console.WriteLine("I am a parent Class: "+DogName);
    }
}

class Cat : Dog{
    public string CatName = "";
    public void sound(){
        Console.WriteLine("I am a child Class: "+CatName);
    }
}

class Cow : Cat{
    public string CowName = "";
    public void cow1(){
        Console.WriteLine("i am a child of child Class: "+CowName);
    }
}

class Program{
    static void Main(string[] args){

        Cow cow= new Cow();

        cow.DogName = "Puppy";
        cow.CatName = "chinmayi";
        cow.CowName = "Rani";

        cow.sound();
        cow.cow1();

    }
}