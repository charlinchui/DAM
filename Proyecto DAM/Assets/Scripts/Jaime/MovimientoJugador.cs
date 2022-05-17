using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Photon.Pun;

public class MovimientoJugador : MonoBehaviour
{

    public PhotonView view;

<<<<<<< HEAD
    public GameObject checkPoint;
=======
    public Transform respawnPoint;

    //public Color color = new Color(255,255,255);
    public SpriteRenderer sprite;
    public int respawnDelay;
>>>>>>> parent of 3b68fc4 (Revert "Merge branch 'main' of https://github.com/charlinchui/DAM")

    public float Speed;
    public float JumpForce;
    public GameObject BulletPrefab;

    private Rigidbody2D Rigidbody2D;
    private Animator Animator;
    private float Horizontal;
    private bool Grounded;
    private float LastShoot;
    private int Health = 5;
    int index = 1;
    GameObject[] cora = new GameObject [5];

    public List<GameObject> hearts;

    private void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
        view = GetComponent<PhotonView>();
<<<<<<< HEAD
        checkPoint = GameObject.FindGameObjectWithTag("CheckPoints");
=======
        sprite = GetComponent<SpriteRenderer>();
        cora = GameObject.FindGameObjectsWithTag("Corazon");
        for(int i = 0; i<cora.Length; i++){
            hearts.Add(cora[i]);
        }
>>>>>>> parent of 3b68fc4 (Revert "Merge branch 'main' of https://github.com/charlinchui/DAM")
    }

    private void Update()
    {

        if (view.IsMine){
            // Movimiento
            Horizontal = Input.GetAxisRaw("Horizontal");

            if (Horizontal < 0.0f) transform.localScale = new Vector3(-1.0f, 1.0f, 1.0f);
            else if (Horizontal > 0.0f) transform.localScale = new Vector3(1.0f, 1.0f, 1.0f);

            Animator.SetBool("Running", Horizontal != 0.0f);

            // Detectar Suelo
            if (Physics2D.Raycast(transform.position, Vector3.down, 0.1f))
            {
                Grounded = true;
            }
            else Grounded = false;

            // Salto
            if (Input.GetKeyDown(KeyCode.W) && Grounded)
            {
                Jump();
            }

            // Disparar
            if (Input.GetKey(KeyCode.Space) && Time.time > LastShoot + 0.25f)
            {
                Shoot();
                LastShoot = Time.time;
            }
        }
    }

    private void FixedUpdate()
    {
        if (view.IsMine){
            Rigidbody2D.velocity = new Vector2(Horizontal * Speed, Rigidbody2D.velocity.y);
        }
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 1.0f) direction = Vector3.right;
        else direction = Vector3.left;

        GameObject bullet = Instantiate(BulletPrefab, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<BulletScript>().SetDirection(direction);
    }

    public void Muerte(){
        this.transform.position = respawnPoint.position;
        sprite.enabled = true;
        Health = 5;
        index = 1;
        for(int i = 0; i<cora.Length;i++){
            cora[i].SetActive(true);
        }
    }

    public void Hit()
    {
        Health -= 1;

        hearts[hearts.Count - index].SetActive(false);
        index ++;

        if (Health == 0)
<<<<<<< HEAD
        {
            //Destroy(gameObject);
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
            this.transform.position = (new Vector2(checkPoint.transform.position.x, checkPoint.transform.position.y));
=======
        {   
            StartCoroutine(waitRespawn());
>>>>>>> parent of 3b68fc4 (Revert "Merge branch 'main' of https://github.com/charlinchui/DAM")
        }
    }

    void OnTriggerEnter2D(Collider2D obj) {
        if(obj.tag == "Check Point"){
            respawnPoint = obj.transform;
        }
    }
    void OnCollisionEnter2D(Collision2D col) {
        if (col.gameObject.tag == "Muerte"){
            StartCoroutine(waitRespawn());
        }
    }

    IEnumerator waitRespawn(){
        sprite.enabled = false;
        yield return new WaitForSeconds(respawnDelay);
        Muerte();
    }

}

