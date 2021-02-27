using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class PlayerInventoryDisplay : MonoBehaviour
{
    public Image[] dartPlaceholders;
    public Sprite iconDartTutup;
    public Sprite iconDartBuka;
    public void OnChangeStarTotal(int dartTotal)
    {
        for (int i = 0; i < dartPlaceholders.Length; ++i)
        {
            if (i < dartTotal)
                dartPlaceholders[i].sprite = iconDartTutup;
            else
                dartPlaceholders[i].sprite = iconDartBuka;
        }
    }
}
