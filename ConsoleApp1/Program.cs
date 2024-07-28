using System;
using System.ComponentModel.DataAnnotations;
public class Person{
    public string name = "mahak";
    public int age = 20;
    public string gender = "Male";
    public int id = 0;

    public Person(){

    }

    public Person(string name, int age, string gender, int id){
        this.name = name;
        this.age = age;
        this.gender = gender;
        this.id = id;
    }
}

public class Program{
    static int Main(string []args){
        int[,] arr = new int[5,5];
        for(int i=0; i<arr.Length; i++){
            Console.WriteLine(arr[i,i]);
        }
        return 0;
    }
}
