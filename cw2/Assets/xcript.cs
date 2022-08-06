using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class xcript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

string heroName = "Batman";
string heroPower = "Flying";
int heroAge = 25;

string villainName = "Joker";
string villainPower = "Running away";
int villainAge = 32;

if (heroAge > villainAge)
{
    print(heroName + "is older.");
}
else if (heroAge == villainAge)
{
    print(heroName + " age eqauls to" + villainName + "age.");
}
else
{
    print(villainName + " is older.");
}