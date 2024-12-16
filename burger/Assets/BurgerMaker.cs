using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurgerMaker : MonoBehaviour
{
    private void Start()

    {

        Debug.Log(CheckIngridients(out string ingridient1, out string ingridient2, out string ingridient3, out string ingridient4));

    }

    static string CheckIngridients(out string ingridient1, out string ingridient2, out string ingridient3, out string ingridient4)

    {

        ingridient1 = "булочка";

        ingridient2 = "сыр";

        ingridient3 = "котлета";

        ingridient4 = "огурцы";

        string[] ingridients = { ingridient1, ingridient2, ingridient3, ingridient4 };

        string[] CB = { "булочка", "сыр", "котлета", "огурцы" };

        string[] BM = { "булочка", "соус", "две котлеты", "огурцы" };

        int check = 0;

        Array.Sort(CB);

        Array.Sort(BM);

        Array.Sort(ingridients);

        for (int i = 0; i < CB.Length; i++)

        {

            if (ingridients[i] == CB[i])

            {

                check++;

            }

        }

        if (check == CB.Length) { return "cheeseburger"; }

        for (int i = 0; i < BM.Length; i++)

        {

            if (ingridients[i] == BM[i])

            {

                check++;

            }

        }

        if (check == BM.Length) { return "bigmack"; }

        return "none";

    }
}
