using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{

    Rigidbody2D rb;
    public float moveSpeed;
    public float rotateAmount;
    float rot;
    int score;
    public GameObject winText;
    public GameObject looseText;
    void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        if(mousePos.x < 0)
            {
                rot = rotateAmount;
            }
            else
            {
                rot = -rotateAmount;
            }
            transform.Rotate(0, 0, rot);
        }
    }
    private void FixedUpdate()
    {
        rb.velocity = transform.up * moveSpeed;
    }

    private IEnumerator OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Food")
        {
            Destroy(collision.gameObject);
            SoundManager.soundMan.PlayCoinSound();
            score++;
            if (score >= 5)
            {
                moveSpeed = 0;
                print("Level Completed");
                winText.SetActive(true);
                yield return new WaitForSeconds(2);
                SceneManager.LoadScene("LevelSelection");
            }
        }
        else if(collision.gameObject.tag == "Danger")
        {
            moveSpeed = 0;
            print("You Crashed! Try Again !");
            looseText.SetActive(true);
            yield return new WaitForSeconds(2);
            SceneManager.LoadScene("LevelSelection");
        }
    }
}
