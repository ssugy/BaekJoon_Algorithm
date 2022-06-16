import java.util.Scanner

fun main() {
    val myScanner : Scanner = Scanner(System.`in`)

    val num1 : Int = myScanner.nextInt()
    val num2 : Int = myScanner.nextInt()

    println(num1 - num2)
}
/**
 * readline이 scanner보다 좀 더 쓰기 애매한 부분이 있어서 scanner로 변경해서 사용함.
 */