using UnityEngine;

public class Player : MonoBehaviour
{
    public float maxHp;

    private float currentHp;
    public Bar healthBar;

    // Use this for initialization
	void Start ()
    {
        currentHp = maxHp;
        healthBar.setValor(currentHp);
    }
	
    public void takeDamage(float damage)
    {
        currentHp -= damage;
        healthBar.updateState(damage);

        if (currentHp <= 0)
        {
            SceneLoader scene = new SceneLoader();
            scene.loadScene(0);
        }
    }
}
