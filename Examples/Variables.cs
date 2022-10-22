using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Variables : MonoBehaviour
{

    byte munber1;
    float number5 = 5f;
    double number6 = 7d;

    char letter = 'a';
    string word = "abc";

    string str1 = "test1";
    string str2 = "test2";

    int number1 = 5;
    int number2 = 10;

    int [] muNumber = {10, 20, 30};
    int [] newNumber = new int[3];
    string[] inventory = {"Sword" , "Potion", "Helmet"};

    Start is called before the first frame update
    void Start()
    {
        number1++;
        int result = number1 + number2;
        merged_string = str1 + str2;
        Debug.Log(sonuc); = print(result);

        Car car1 = new Car("blue", 2022);
        car1.modelYear = 2022;
        car1.color = "blue";

        car1.Drive();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

public class Car
{
    public string color;
    public int modelYear;
    private bool gasPedal;

    public Car(string _color, int _modelYear)
    {
        this.color = _color;
        this.modelYear = _modelYear;
    }

    public void Drive()
    {
        Debug.Log("Araba Gidiyor");
    }

    public void Horn()
    {
        Debug.Log("Düt Düt");
    }
}



