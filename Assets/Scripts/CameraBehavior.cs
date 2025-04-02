using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField] private GameObject background;
    private SpriteRenderer BGsprite;
    
    // Start is called before the first frame update
    void Start()
    {
        BGsprite = background.GetComponent<SpriteRenderer>();
        Vector2 spriteSize = BGsprite.sprite.bounds.size;
        //Debug.Log(spriteSize);
        //Debug.Log(transform.localScale);
        transform.localScale = new Vector3(spriteSize.x * 2, spriteSize.y * 2, 1);
        //Debug.Log(transform.localScale);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
