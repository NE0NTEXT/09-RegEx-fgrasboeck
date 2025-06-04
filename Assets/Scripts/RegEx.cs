using UnityEngine;
using TMPro;

using System.Text.RegularExpressions;

public class RegEX : MonoBehaviour
{
    public TMP_InputField emailInput;
    public TMP_Text resultText;


    void Start()
    {
        resultText.text = "";
    }

    public void ValidateEmail()
    {
        string email = emailInput.text;
        string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";

        if (Regex.IsMatch(email, pattern))
        {
            resultText.text = "✅ Gültige E-Mail-Adresse!";
            resultText.color = Color.green;
        }
        else
        {
            resultText.text = "❌ Ungültige E-Mail-Adresse!";
            resultText.color = Color.red;
        }
    }
}
