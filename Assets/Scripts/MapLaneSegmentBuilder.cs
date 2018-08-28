/**
 * Copyright (c) 2018 LG Electronics, Inc.
 *
 * This software contains code licensed as described in LICENSE.
 *
 */

using System.Collections.Generic;
using UnityEngine;

public class MapLaneSegmentBuilder : MapSegmentBuilder
{
    [Header("Apollo HD Map")]
    public List<MapBoundaryLineSegmentBuilder> leftBoundaryBuilders;
    public List<MapBoundaryLineSegmentBuilder> rightBoundaryBuilders;

    [Header("Autoware Vector Map")]
    public Map.Autoware.LaneInfo laneInfo;

    public MapLaneSegmentBuilder() : base() { }

    public override void AddPoint()
    {
        base.AddPoint();
    }

    public override void RemovePoint()
    {
        base.RemovePoint();
    }

    public override void ResetPoints()
    {
        base.ResetPoints();
    }
}