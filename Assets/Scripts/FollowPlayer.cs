using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject player;
    private Vector3 offset = new Vector3(0, 5, -7);


    //카메라가 떨리는 현상을 제거하려고 lateUpdate사용 -> 어떤경우엔 카메라 위치가 트럭보다 먼저 갱신될 수 있기 떄문.
    void LateUpdate()
    {
        transform.position = player.transform.position + offset;
    }

}
