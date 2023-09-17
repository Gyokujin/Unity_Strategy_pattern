using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MachineGun : GunWeapon
{
    public override void InitSetting()
    {
        data.delayTime = 0.2f;
        data.info = "현재 무기 : 기관총";
        data.soundEffect = "두두두!";
        data.maxBullet = 50;
        data.bullet = Resources.Load<GameObject>("DefaultBullet");
    }

    public override void Using(Transform tip, TextMesh sound, Transform player)
    {
        base.Using(tip, sound, player);
        player.position += new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0) * 10 * Time.deltaTime;
    }
}