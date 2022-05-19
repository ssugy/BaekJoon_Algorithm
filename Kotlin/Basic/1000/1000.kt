

import java.util.Scanner

fun main() {
    val myScanner : Scanner = Scanner(System.`in`)

    val num1 : Int = myScanner.nextInt()
    val num2 : Int = myScanner.nextInt()

    println(num1 + num2)
}

/**
 * 2등 정답
 * fun main()=print(readLine()!!.split(" ").sumBy{it[0]-'0'})
 * 해석은 된다.
 */

 /**
  * 1등 정답
  * fun main()=print(readln().sumOf{it-' '}-32)
  * 해석이 안된다.
  */


/**
 * 좋은방법이 많음. - Selector를 이용한 sumOf
 * 
 * 기본예제
 * fun main(args: Array<String>) {
    val orderArray = arrayOf(OrderItem("Cake", 15000, 3),
                            OrderItem("Coffee", 1500, 10),
                            OrderItem("Tea", 2000, 10))
                // selector it를 사용한다.
    val totalCount = orderArray.sumOf {it.count} 
    val totalPrice = orderArray.sumOf {it.count * it.price} // 각 주문 갯수 * 가격
    val minPrice = orderArray.minOf{ it.price } // 배열속 price 원소의 최소값을 반환
    val maxCount = orderArray.maxOf{ it.count } // 배열속 count 원소의 최소값을 반환
    println("totalCount : $totalCount")
    println("totalPrice : $totalPrice")
    println("minPrice : $minPrice")
    println("maxCount : $maxCount")
    }
 */