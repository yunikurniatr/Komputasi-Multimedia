using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlayerInventoryDisplay : MonoBehaviour
{
    public Text starText;
    public void OnChangeCarryingStar(bool carryingStar)
    {
        string starMessage = "Tidak Bawa Dart :(";
        if (carryingStar) starMessage = "Bawa Dart :)"; starText.text = starMessage;
    }
}
