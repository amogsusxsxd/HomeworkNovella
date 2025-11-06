import java.util.Scanner;

public class Calculator {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("Введите номер операции: 1.Сложение 2.Вычитание 3.Умножение");
        int operationNumber = scanner.nextInt();

        System.out.print("Введите первое число: ");
        double num1 = scanner.nextDouble();

        System.out.print("Введите второе число: ");
        double num2 = scanner.nextDouble();

        double result;

        switch (operationNumber) {
            case 1:
                result = num1 + num2;
                System.out.println("Результат сложения: " + result);
                break;
            case 2:
                result = num1 - num2;
                System.out.println("Результат вычитания: " + result);
                break;
            case 3:
                result = num1 * num2;
                System.out.println("Результат умножения: " + result);
                break;
            default:
                System.out.println("Операция неопределена");
                break;
        }
    }
}