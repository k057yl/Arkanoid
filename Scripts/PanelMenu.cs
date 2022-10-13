using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine;


public class PanelMenu : MonoBehaviour
{
    [SerializeField] ParticleSystem ParticleSystem;
    [SerializeField] Text text;
    public int lives = 3;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            ParticleSystem.Play();
            lives--;
            text.text = lives.ToString();
        }
        if(lives <= 0)
        {
            SceneManager.LoadScene(1);
        }
    }
}
