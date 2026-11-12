using UnityEngine;

public class BurgerMaker : MonoBehaviour
{
    void Start()
    {
        string resultBurger;

        MakeBurger("сыр", "огурец", "кетчуп", "котлета", out resultBurger);
        Debug.Log(resultBurger);

        MakeBurger("булочка с кунжутом", "две котлеты", "специальный соус", "", out resultBurger);
        Debug.Log(resultBurger);

        MakeBurger("огурцы", "салат", "лук", "помидор", out resultBurger);
        Debug.Log(resultBurger);
    }

    void MakeBurger(string item1, string item2, string item3, string item4, out string burgerName)
    {
        string[] items = { item1, item2, item3, item4 };

        int cheeseburgerCount = 0;
        int bigMacCount = 0;

        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == "сыр" || items[i] == "кетчуп" || items[i] == "котлета" || items[i] == "огурец")
            {
                cheeseburgerCount++;
            }

            if (items[i] == "специальный соус" || items[i] == "булочка с кунжутом" || items[i] == "две котлеты")
            {
                bigMacCount++;
            }
        }

        if (cheeseburgerCount == 4)
        {
            burgerName = "чизбургер";
        }
        else if (bigMacCount == 3 && (item1 == "" || item2 == "" || item3 == "" || item4 == ""))
        {
            burgerName = "биг мак";
        }
        else
        {
            burgerName = "Бургер не получился";
        }
    }
}
