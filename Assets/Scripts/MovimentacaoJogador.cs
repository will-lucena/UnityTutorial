using UnityEngine;

public class MovimentacaoJogador : MonoBehaviour
{
    private Rigidbody2D corpo;
    private Animator controladorAnimacao;
    private float entradaHorizontal;
    private bool movendoPraFrente;

    public float modificadorVelocidade;
    public float forcaPulo;

	// Use this for initialization
	void Start ()
    {
        corpo = GetComponent<Rigidbody2D>();
        controladorAnimacao = GetComponent<Animator>();
        movendoPraFrente = true;
	}
	
	// Update is called once per frame
	void Update ()
    {
        entradaHorizontal = Input.GetAxis("Horizontal");

        if ((entradaHorizontal < 0 && movendoPraFrente) || (entradaHorizontal > 0 && !movendoPraFrente))
        {
            girar();
        }
        corpo.velocity = new Vector3(modificadorVelocidade * entradaHorizontal, corpo.velocity.y, 0);
        controladorAnimacao.SetFloat("Velocidade", Mathf.Abs(entradaHorizontal));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            controladorAnimacao.SetTrigger("Pular");
            corpo.AddForce(Vector2.up * forcaPulo, ForceMode2D.Impulse);
        }
	}
    
    private void girar()
    {
        if (movendoPraFrente)
        {
            transform.rotation = Quaternion.Euler(0, 190, 0);
        }
        else
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }

        movendoPraFrente = !movendoPraFrente;
    }
}
