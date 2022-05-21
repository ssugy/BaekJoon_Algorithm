

import java.text.DecimalFormat

fun main() {
    val price = 1000000000
    val format = DecimalFormat("#,###")
    print(format.format(price))
}