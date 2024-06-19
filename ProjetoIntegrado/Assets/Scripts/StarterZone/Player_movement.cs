using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player_movement : MonoBehaviour, IDataPersistence
{
    public Rigidbody2D rb;
    public GameObject tutorial;
    public GameObject tutorial_movement;
    public GameObject tutorial_interact;
    public GameObject tutorial_run;
    private Vector2 direction;
    public GameObject interactingObject;
    public Animator animator;
    public bool firstStart = true;
    [SerializeField] public float speed;

    private float durationC = 6;


    public void LoadData(GameData data)
    {
        this.transform.position = data.PlayerPosition;
        this.firstStart = data.FirstStart;
    }
    public void SaveData(ref GameData data)
    {
        data.PlayerPosition = this.transform.position;
        data.FirstStart = this.firstStart;
    }

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();

        //deixa o player inativo durante o inicio do jogo
        gameObject.SetActive(false);

        //chama a função activePlayer com um delay de x segundos
        Invoke(nameof(activePlayer), durationC);

        PlayerSO playerSO = gameObject.GetComponent<PlayerSO>();
        playerSO.playerSO.vida = playerSO.playerSO.maxVida;
        Debug.Log("HP: " + playerSO.playerSO.vida + "/" + playerSO.playerSO.maxVida);

        //define todos os tutoriais como inativos
        tutorial.SetActive(false);
        tutorial_movement.SetActive(false);
        tutorial_interact.SetActive(false);
        tutorial_run.SetActive(false);
    }

    private void FixedUpdate()
    {
        //move o player
        rb.velocity = direction * speed;

        // define se ta se movendo
        bool isMoving = direction != Vector2.zero;
        animator.SetBool("isMoving", isMoving);

        // determina a direção para ajustar as variaveis
        if (direction == Vector2.right)
        {
            animator.SetBool("isRight", true);
            animator.SetBool("isLeft", false);
            animator.SetBool("isUp", false);
            animator.SetBool("isDown", false);
        }
        else if (direction == Vector2.left)
        {
            animator.SetBool("isLeft", true);
            animator.SetBool("isUp", false);
            animator.SetBool("isDown", false);
            animator.SetBool("isRight", false);
        }
        else if (direction == Vector2.up)
        {
            animator.SetBool("isUp", true);
            animator.SetBool("isRight", false);
            animator.SetBool("isLeft", false);
            animator.SetBool("isDown", false);
        }
        else if (direction == Vector2.down)
        {
            animator.SetBool("isDown", true);
            animator.SetBool("isRight", false);
            animator.SetBool("isLeft", false);
            animator.SetBool("isUp", false);
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject != null)
        {
            interactingObject = collision.gameObject;
        }
    }

    private void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject == interactingObject)
        {
            interactingObject = null;
        }
    }

    //trigger de acesso a colisão das zonas de tutorial

    //trigger ao entrar na area
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("movementTutorial"))
        {
            tutorial.SetActive(true);
            tutorial_movement.SetActive(true);
        }

        if (collision.gameObject.CompareTag("interactTutorial"))
        {
            tutorial.SetActive(true);
            tutorial_interact.SetActive(true);
        }

        if (collision.gameObject.CompareTag("runTutorial"))
        {
            tutorial.SetActive(true);
            tutorial_run.SetActive(true);
        }
    }
  
    //trigger ao sair da area
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("movementTutorial"))
        {
            tutorial.SetActive(false);
            tutorial_movement.SetActive(false);
            
        }

        if (collision.gameObject.CompareTag("interactTutorial"))
        {
            tutorial.SetActive(false);
            tutorial_interact.SetActive(false);
        }

        if (collision.gameObject.CompareTag("runTutorial"))
        {
            tutorial.SetActive(false);
            tutorial_run.SetActive(false);
        }
    }
    public void OnInteraction(InputAction.CallbackContext context)
    {
        if (context.started && interactingObject != null && interactingObject.CompareTag("Enemy"))
        {
            GameObject gameObject = GameObject.Find("GameManager");
            gameObject.GetComponent<GameManagerScript>().SceneTransition(GetComponent<PlayerSO>().playerSO, interactingObject.GetComponent<EnemySO>().enemySO);

            EnemyDestroyed(interactingObject.GetComponent<HasDefeted>().id);

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
        
        if(context.started && interactingObject != null && interactingObject.CompareTag("Door"))
        {
            Debug.Log("Interagiu com a porta");
        }

        if(context.started && interactingObject != null && interactingObject.CompareTag("Chest")){

        }
            
    }

    public void EnemyDestroyed(string enemyID)
    {
        PlayerPrefs.SetInt(enemyID, 1);
        PlayerPrefs.Save();
    }

    public void OnMovement(InputAction.CallbackContext context)
    {
        direction = context.ReadValue<Vector2>();
    }

    public void OnPress(InputAction.CallbackContext context)
    {
        if (context.started)
        {
            speed = (float)(1.5 * speed);
        }

        if (context.canceled)
        {
            speed = (float)(speed / 1.5);
        }
    }

    private void activePlayer()
    {
        gameObject.SetActive(true);
    }
}


