using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class day21 : MonoBehaviour
{
    //hero
    string heroName = "8awi";
    int heroHeight = 145;
    int heroAge = 78;
    float heroSuperPower = 150.5f;
    //villain
    string villainName = "ridi";
    int villainHeight = 190;
    int villainAge = 35;
    float villainSuperPower = 100.5f;

    void Start()
    {
       int ageDifference = heroAge - villainAge;
        print(" im your hero and my name is " + heroName + " btw im not so tall my height is " + heroHeight + " and im " + heroAge + " old ");
        print(" im the villain and my name is " + villainName + " my height is " + villainHeight + " and im " + villainAge + " old ");
        print("the difference in age between" + heroName + " and " + villainName + "is" + ageDifference);
    }


}