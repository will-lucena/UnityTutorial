using UnityEngine;

public class CameraScript : MonoBehaviour
{
    public Transform alvoTransform;
    public Transform[] bordas;
    public Transform[] bordasJogador;

    public float sobraX;
    public float sobraY;

    // Update is called once per frame
	void Update ()
    {
        //*
        float posicaoX = checarPosicao();
        float posicaoY = checarAltura();

        transform.position = new Vector3(posicaoX, posicaoY, -10);
        /**/
    }

    private float checarAltura()
    {
        if (bordasJogador[3].position.y < bordas[3].position.y)
        {
            return bordas[3].position.y + 5;
        }
        if (bordasJogador[1].position.y > bordas[1].position.y)
        {
            return bordas[1].position.y - 5;
        }

        return alvoTransform.position.y + sobraY;
    }

    private float checarPosicao()
    {
        if (Mathf.Min(bordasJogador[0].position.x, bordasJogador[2].position.x) + sobraX < bordas[0].position.x)
        {
            return bordas[0].position.x + 9;
        }

        if (Mathf.Max(bordasJogador[0].position.x, bordasJogador[2].position.x) + sobraX > bordas[2].position.x)
        {
            return bordas[2].position.x - 9;
        }

        return alvoTransform.position.x + sobraX;
    }
    
}
