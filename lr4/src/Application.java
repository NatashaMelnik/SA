import java.util.ArrayList;
import java.util.List;

public class Application {
    public static void main(String[] args) {
        polynomial p = new polynomial();
        List<Double>valuesOfFunc = new ArrayList<>();
        valuesOfFunc.add(11.36);
        valuesOfFunc.add(11.4);
        valuesOfFunc.add(11.4);
        valuesOfFunc.add(11.41);
        valuesOfFunc.add(11.41);
        valuesOfFunc.add(11.42);
        valuesOfFunc.add(11.44);
        int rows = valuesOfFunc.size() - 2;
        Double[][] F = polynomial(valuesOfFunc);
        for (Double[] aF : F) {
            for (Double anAF : aF) {
                System.out.print(anAF + "    ");}
            System.out.println();}
        Double[][] normF = normalization(F, rows);
        double[] B = new double[rows - 1];
        for (int i = 0; i< rows - 1; i++) {
            for (int j = 0; j < 1; j++) {
                B[i] = normF[i][j];}}
        double[][] A = new double[rows - 1][rows - 1];
        for (int i = 0; i<A.length; i++) {
            for (int j = 0; j < A[i].length; j++) {
                A[i][j] = normF[i][j+1];}}
        RealMatrix coefficients = MatrixUtils.createRealMatrix(A);
        DecompositionSolver solver = new LUDecomposition(coefficients).getSolver();
        RealVector constants = MatrixUtils.createRealVector(B);
        RealVector solution = solver.solve(constants);
        double[] X = new double[4];
        for(int i = 0; i<X.length; i++) {
            X[i] = solution.getEntry(i);}
        for (int i = 0; i<X.length; i++) {
            System.out.println("X[" + (i+1) + "] = " + X[i]) ;}
        double Fi = X[0] + X[1] * valuesOfFunc.get(valuesOfFunc.size() - 1) + X[2] * valuesOfFunc.get(valuesOfFunc.size() - 2) + X[3] * valuesOfFunc.get(valuesOfFunc.size() - 1) * valuesOfFunc.get(valuesOfFunc.size() - 2);
        System.out.println("Fi = " + Fi);}}
