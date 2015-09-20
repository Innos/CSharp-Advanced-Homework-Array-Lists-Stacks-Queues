package _01_Geometry.ThreeDimensional;

import _01_Geometry.Interfaces.AreaMeasurable;
import _01_Geometry.Interfaces.VolumeMeasurable;
import _01_Geometry.Shape;

import java.util.Arrays;

public abstract class SpaceShape extends Shape implements AreaMeasurable,VolumeMeasurable,Comparable<SpaceShape> {

    protected SpaceShape(Vertex3D...vertices) {
        super(Arrays.asList(vertices));
    }

    @Override
    public int compareTo(SpaceShape o) {
        return Double.compare(this.getVolume(),o.getVolume());
    }
}
