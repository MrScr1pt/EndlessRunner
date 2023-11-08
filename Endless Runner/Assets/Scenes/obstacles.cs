using UnityEngine;

public class obstacles : MonoBehaviour
{
    public float Movespeed = 25f;

    // Update is called once per frame
    void Update()
    {
        this.transform.Translate(Vector3.forward * Movespeed * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("barrier") == true)
        {
            Destroy(this.gameObject);
        }
    }
}
