using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class day2 : MonoBehaviour
{
    string heroname = "abas";
    int Heropower = 100;
    float playerpeed = 5.2f;

    string villainName = "ali";
    int villainpower = 200;
    // Start is called before the first frame update
    void Start()
    {
        if(Heropower > villainpower)
        {
            print("heropower stronger than villainpower");
        }
        else if(villainpower > Heropower)
        {
            print("villainpower srtonger than heropower");
        }
        else
        {
            print("heropower equal villain power");
        }
        print(playerpeed);
        setspeed(2.5f);
        print(playerpeed);
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void setspeed(float speed)
    {
        playerpeed = speed;
    }
}
