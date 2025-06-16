using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class SistemaInterativo : MonoBehaviour
{

    [SerializeField] private Sprite sTrancado;
    [SerializeField] private Sprite sAberto;
    [SerializeField] private Sprite sInteragir;
    [SerializeField] private Sprite sClose;
    [SerializeField] private Sprite sPlay;
    [SerializeField] private Sprite sLigar;
    [SerializeField] private Image spriteInterface;
    [SerializeField] private float tempoExibir;
    void Start()
    {
      spriteInterface.enabled = false;
    }
void Update()
    {
        
    }

    public void ExibirLigar()
    {
        StartCoroutine(ExibirSprite(sLigar));
    }

    public void ExibirPlay()
    {
        StartCoroutine(ExibirSprite(sPlay));
    }

    public void ExibirClose()
    {
        StartCoroutine(ExibirSprite(sClose));
    }

    public void ExibirInteragir()
    {
        StartCoroutine(ExibirSprite(sInteragir));
    }

    public void ExibirTrancado()
    {
        StartCoroutine(ExibirSprite(sTrancado));
    }

    public void ExibirAberto()
    {
        StartCoroutine(ExibirSprite(sAberto));
    }

    IEnumerator ExibirSprite(Sprite sprite)
    {
        spriteInterface.enabled = true;
        spriteInterface.sprite = sprite;
        yield return new WaitForSeconds(5f);
        spriteInterface.enabled = false;
    }
}
