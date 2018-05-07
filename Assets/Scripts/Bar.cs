using UnityEngine;
using UnityEngine.UI;

public class Bar : MonoBehaviour
{
    public Image bar;
    [HideInInspector] public float maxValor;

    private float currentValor;

    public void updateState(float valor)
    {
        currentValor -= valor;

        float ratio = currentValor / maxValor;

        bar.fillAmount = ratio;
        bar.color = Color.Lerp(Color.red, Color.green, ratio);
    }

    public void setValor(float valor)
    {
        currentValor = maxValor = valor;
        updateState(0);
    }
}
