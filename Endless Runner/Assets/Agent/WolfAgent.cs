using System.Collections;
using System.Collections.Generic;
//using Unity.MLAgents;
//using Unity.MLAgents.Sensors;
using UnityEngine;

public class WolfAgent : MonoBehaviour
{
    [SerializeField] float speed;


    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float z = Input.GetAxisRaw("Vertical");
        transform.Translate(new Vector3(x, 0, z) * speed * Time.deltaTime);

        Vector3 currentPos = transform.position;

        currentPos.x = Mathf.Clamp(currentPos.x, -20, 8);
        currentPos.z = Mathf.Clamp(currentPos.z, 15, 230);

        transform.position = currentPos;
    }
}
