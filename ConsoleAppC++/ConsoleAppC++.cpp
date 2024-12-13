#include <iostream>
#include <string>
#include <algorithm>

int main() {
    std::string firstName = "Sue";
    int age = 189;

    if (age >= 0 && age < 18) {
        std::cout << "You are a child" << std::endl;
    }
    else if (age >= 18 && age < 66) {
        std::cout << "You should have a job" << std::endl;
    }
    else if (age >= 66) {
        std::cout << "Hopefully you are retired or retiring soon." << std::endl;
    }
    else {
        std::cout << "Age was not in an expected range." << std::endl;
    }

    // std::transform(firstName.begin(), firstName.end(), firstName.begin(), ::tolower);
    // if (firstName == "tim" || firstName == "sue") {
    //     std::cout << "Hello Professor" << std::endl;
    // } else if (firstName == "tom") {
    //     std::cout << "Hello Tom" << std::endl;
    // } else {
    //     std::cout << "I don't know you" << std::endl;
    // }

    return 0;
}
