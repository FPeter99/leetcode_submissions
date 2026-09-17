bool check_one_column(vector<vector<char>>& board, int oszlop){

    vector<char> szerepel;

    for(int hanyadik = 0; hanyadik < 9; hanyadik++){

        if(board[hanyadik][oszlop] != '.'){

            for(int benne = 0; benne < szerepel.size(); benne++){

                if(board[hanyadik][oszlop] == szerepel.at(benne)){

                    return false;

                }

            }
            szerepel.push_back(board[hanyadik][oszlop]);
        }
    }
    return true;
}

bool check_sor(vector<char> sor){

    vector<char> szerepel;

    for (int karakter = 0; karakter < sor.size(); karakter++) {

        if(sor.at(karakter) != '.'){

            for(int benne = 0; benne < szerepel.size(); benne++){

                if(sor.at(karakter) == szerepel.at(benne)){
                    return false;
                }
            }
            szerepel.push_back(sor.at(karakter));
        }
    }
    return true;
}



bool check_boxes(vector<vector<char>>& board){
    vector<char> box1;
    vector<char> box2;
    vector<char> box3;
    vector<char> box4;
    vector<char> box5;
    vector<char> box6;
    vector<char> box7;
    vector<char> box8;
    vector<char> box9;
    for(int y = 0; y < 9; y++){
        for(int x = 0; x < 9; x++){
            if(board[y][x] != '.'){
                if(0 <= x && x <= 2 && 0 <= y && y <= 2){
                    box1.push_back(board[y][x]);
                }else if(0 <= x && x <= 2 && 3 <= y && y <= 5){
                    box2.push_back(board[y][x]);
                }else if(0 <= x && x <= 2 && 6 <= y && y <= 8){
                    box3.push_back(board[y][x]);
                }
                   
                else if(3 <= x && x <= 5 && 0 <= y && y <= 2){
                    box4.push_back(board[y][x]);
                }else if(3 <= x && x <= 5 && 3 <= y && y <= 5){
                    box5.push_back(board[y][x]);
                }else if(3 <= x && x <= 5 && 6 <= y && y <= 8){
                    box6.push_back(board[y][x]);
                }

                else if(6 <= x && x <= 8 && 0 <= y && y <= 2){
                    box7.push_back(board[y][x]);
                }else if(6 <= x && x <= 8 && 3 <= y && y <= 5){
                    box8.push_back(board[y][x]);
                }else if(6 <= x && x <= 8 && 6 <= y && y <= 8){
                    box9.push_back(board[y][x]);
                }
            }
        }
    }
    vector<vector<char>> boxes = {box1, box2, box3, box4, box5, box6, box7, box8, box9};
    for(int i = 0; i < 9; i++){
        bool good = check_sor(boxes[i]);
        if(!good){
            return false;
        }
    }
    return true;



}


class Solution {
public:
    bool isValidSudoku(vector<vector<char>>& board) {
        for(int i = 0; i < 9; i++){
            if(!check_one_column(board, i) || !check_sor(board[i])){
                return false;
            }
        }
        if (!check_boxes(board)) {
            return false;
        }
        return true;
    };
};
