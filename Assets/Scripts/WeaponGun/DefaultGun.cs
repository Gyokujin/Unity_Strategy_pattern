using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DefaultGun : GunWeapon
{
    public override void InitSetting()
    {
        data.delayTime = 1f;
        data.info = "ÇöÀç ¹«±â : ±âº» ±ÇÃÑ";
        data.soundEffect = "»§¾ß!";
        data.maxBullet = -1;
        data.bullet = Resources.Load<GameObject>("DefaultBullet");
    }

    public override void Using(Transform tip, TextMesh sound, Transform player)
    {
        base.Using(tip, sound, player);
        player.transform.position += new Vector3(Input.GetAxis("Horizontal"), 0, 0) * 10 * Time.deltaTime;
    }
}