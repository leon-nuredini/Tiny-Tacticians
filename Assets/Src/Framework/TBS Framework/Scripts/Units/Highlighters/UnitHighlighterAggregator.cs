﻿using System.Collections.Generic;
using UnityEngine;

namespace TbsFramework.Units.Highlighters
{
    public class UnitHighlighterAggregator : MonoBehaviour
    {
        public List<UnitHighlighter> MarkAsAttackingFn;
        public List<UnitHighlighter> MarkAsDefendingFn;
        public List<UnitHighlighter> MarkAsSelectedFn;
        public List<UnitHighlighter> MarkAsFriendlyFn;
        public List<UnitHighlighter> MarkAsFinishedFn;
        public List<UnitHighlighter> MarkAsDestroyedFn;
        public List<UnitHighlighter> MarkAsReachableEnemyFn;
        public List<UnitHighlighter> MarkAsEvadingFn;
        public List<UnitHighlighter> UnMarkFn;
        public List<UnitHighlighter> MarkAsEnemyTargetedEnemyFn;
        public List<UnitHighlighter> MarkEnemyCursorDisabledFn;
        public List<UnitHighlighter> MarkAsFriendlyCursorFn;
    }
}
