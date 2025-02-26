using System.Collections;
using TbsFramework.Units;
using TbsFramework.Units.Highlighters;
using UnityEngine;

public class EvadeAnimation : UnitHighlighter
{
    public float Magnitude = 1f;

    public override void Apply(Unit unit, Unit otherUnit)
    {
        StartCoroutine(EvadeAnimationCoroutine(unit, otherUnit));
    }

    private IEnumerator EvadeAnimationCoroutine(Unit unit, Unit otherUnit)
    {
        var StartingPosition = unit.transform.position;

        var heading = otherUnit.transform.localPosition - unit.transform.localPosition;
        var direction = -(heading / heading.magnitude * Magnitude);
        float startTime = Time.time;

        while (startTime + 0.25f > Time.time)
        {
            unit.transform.localPosition = Vector3.Lerp(unit.transform.localPosition,
                unit.transform.localPosition + (direction / 2.5f), ((startTime + 0.25f) - Time.time));
            yield return 0;
        }

        startTime = Time.time;
        while (startTime + 0.25f > Time.time)
        {
            unit.transform.localPosition = Vector3.Lerp(unit.transform.localPosition,
                unit.transform.localPosition - (direction / 2.5f), ((startTime + 0.25f) - Time.time));
            yield return 0;
        }

        unit.transform.localPosition = StartingPosition;
    }
}