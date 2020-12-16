import java.util.List;

public class polynomial {
    private static Double[][] polynomial(List<Double> values) {
        Double[][] F = new Double[values.size() - 2][5];
        for (int i = 0; i<F.length; i++) {
            F[i][0] = values.get(i + 2);
            F[i][1] = 1.;
            F[i][2] = values.get(i + 1);
            F[i][3] = values.get(i);
            F[i][4] = values.get(i) * values.get(i + 1);}
        return F;}
}
