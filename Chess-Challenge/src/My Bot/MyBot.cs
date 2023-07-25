using ChessChallenge.API;
using System;

public class MyBot : IChessBot
{
    public int[] PieceValues = { 0, 100, 300, 300, 500, 900, 0 };

    // public int[,] PieceTables = {
    //     {
    //          0,  0,  0,  0,  0,  0,  0,  0,
    //         50, 50, 50, 50, 50, 50, 50, 50,
    //         10, 10, 20, 30, 30, 20, 10, 10,
    //         5,  5, 10, 25, 25, 10,  5,  5,
    //         0,  0,  0, 20, 20,  0,  0,  0,
    //         5, -5,-10,  0,  0,-10, -5,  5,
    //         5, 10, 10,-20,-20, 10, 10,  5,
    //         0,  0,  0,  0,  0,  0,  0,  0
    //     },
    //     {
    //         -50,-40,-30,-30,-30,-30,-40,-50,
    //         -40,-20,  0,  0,  0,  0,-20,-40,
    //         -30,  0, 10, 15, 15, 10,  0,-30,
    //         -30,  5, 15, 20, 20, 15,  5,-30,
    //         -30,  0, 15, 20, 20, 15,  0,-30,
    //         -30,  5, 10, 15, 15, 10,  5,-30,
    //         -40,-20,  0,  5,  5,  0,-20,-40,
    //         -50,-40,-30,-30,-30,-30,-40,-50
    //     },
    //     {
    //         -20,-10,-10,-10,-10,-10,-10,-20,
    //         -10,  0,  0,  0,  0,  0,  0,-10,
    //         -10,  0,  5, 10, 10,  5,  0,-10,
    //         -10,  5,  5, 10, 10,  5,  5,-10,
    //         -10,  0, 10, 10, 10, 10,  0,-10,
    //         -10, 10, 10, 10, 10, 10, 10,-10,
    //         -10,  5,  0,  0,  0,  0,  5,-10,
    //         -20,-10,-10,-10,-10,-10,-10,-20
    //     },
    //     {
    //           0,  0,  0,  0,  0,  0,  0,  0,
    //           5, 10, 10, 10, 10, 10, 10,  5,
    //          -5,  0,  0,  0,  0,  0,  0, -5,
    //          -5,  0,  0,  0,  0,  0,  0, -5,
    //          -5,  0,  0,  0,  0,  0,  0, -5,
    //          -5,  0,  0,  0,  0,  0,  0, -5,
    //          -5,  0,  0,  0,  0,  0,  0, -5,
    //           0,  0,  0,  5,  5,  0,  0,  0
    //     },
    //     {
    //         -20,-10,-10, -5, -5,-10,-10,-20,
    //         -10,  0,  0,  0,  0,  0,  0,-10,
    //         -10,  0,  5,  5,  5,  5,  0,-10,
    //         -5,  0,  5,  5,  5,  5,  0, -5,
    //         0,  0,  5,  5,  5,  5,  0, -5,
    //         -10,  5,  5,  5,  5,  5,  0,-10,
    //         -10,  0,  5,  0,  0,  0,  0,-10,
    //         -20,-10,-10, -5, -5,-10,-10,-20
    //     },
    //     {
    //         -30,-40,-40,-50,-50,-40,-40,-30,
    //         -30,-40,-40,-50,-50,-40,-40,-30,
    //         -30,-40,-40,-50,-50,-40,-40,-30,
    //         -30,-40,-40,-50,-50,-40,-40,-30,
    //         -20,-30,-30,-40,-40,-30,-30,-20,
    //         -10,-20,-20,-20,-20,-20,-20,-10,
    //         20, 20,  0,  0,  0,  0, 20, 20,
    //         20, 30, 10,  0,  0, 10, 30, 20
    //     }
    // };

    // public int[,] PieceTables = {
    //     { // first column in side, next is center
    //         50, 50,
    //         7, 22,
    //         0, 10,
    //         7, -5
    //     },
    //     {
    //         -37, -15,
    //         -14, 15,
    //         -14, 15,
    //         -37, -15
    //     },
    //     {
    //         -10, -5,
    //         -4, 7,
    //         -3, 10,
    //         -9, -5
    //     },
    //     {
    //           7, 5,
    //           -2, 0,
    //           -2, 0,
    //           -1, 2
    //     },
    //     {
    //         -10, -7,
    //         -7, 5,
    //         -2, 5,
    //         -10, -3
    //     },
    //     {
    //         -35, -45,
    //         -35, -45,
    //         -20, -27,
    //         22, 2
    //     }
    // };

    public int[,] PieceTables = {
        {
            0,  0,  0,  0,
            50, 50, 50, 50,
            10, 10, 20, 30,
            5,  5, 10, 25,
            0,  0,  0, 20,
            5, -5,-10,  0,
            5, 10, 10,-20,
            0,  0,  0,  0
        },
        {
            -50,-40,-30,-30,
            -40,-20,  0,  0,
            -30,  0, 10, 15,
            -30,  5, 15, 20,
            -30,  0, 15, 20,
            -30,  5, 10, 15,
            -40,-20,  0,  5,
            -50,-40,-30,-30
        },
        {
            -20,-10,-10,-10,
            -10,  0,  0,  0,
            -10,  0,  5, 10,
            -10,  5,  5, 10,
            -10,  0, 10, 10,
            -10, 10, 10, 10,
            -10,  5,  0,  0,
            -20,-10,-10,-10,
        },
        {
            0,  0,  0,  0,
            5, 10, 10, 10,
            -5,  0,  0,  0,
            -5,  0,  0,  0,
            -5,  0,  0,  0,
            -5,  0,  0,  0,
            -5,  0,  0,  0,
            0,  0,  0,  5
        },
        {
            -20,-10,-10, -5,
            -10,  0,  0,  0,
            -10,  0,  5,  5,
            -5,  0,  5,  5,
            0,  0,  5,  5,
            -10,  5,  5,  5,
            -10,  0,  5,  0,
            -20,-10,-10, -5
        },
        {
            -30,-40,-40,-50,
            -30,-40,-40,-50,
            -30,-40,-40,-50,
            -30,-40,-40,-50,
            -20,-30,-30,-40,
            -10,-20,-20,-20,
            20, 20,  0,  0,
            20, 30, 10,  0
        }
    };

    // public double Distance(Move move)
    // {
    //     int x = move.StartSquare.Rank - move.TargetSquare.Rank;
    //     int y = move.StartSquare.File - move.TargetSquare.File;
    //     int squares = x * x + y * y;
    //     return Math.Sqrt(squares);
    // }

    public int EvaluatePosition(Board board)
    {
        PieceList[] AllPieceLists = board.GetAllPieceLists();
        int score = 0;
        for (int i = 0; i < AllPieceLists.Length; i++)
        {
            if (AllPieceLists[i].Count == 0)
            {
                continue;
            }

            int PieceType = (int)AllPieceLists[i].TypeOfPieceInList;

            for (int p = 0; p < AllPieceLists[i].Count; p++)
            {
                int PieceSquareIndex = AllPieceLists[i].GetPiece(p).Square.Index;
                int File = AllPieceLists[i].GetPiece(p).Square.File;
                int Rank = AllPieceLists[i].GetPiece(p).Square.Rank;

                // for highly compressed tables
                // bool isCenter = (File > 1 && File < 6);

                // for half tables
                if (File > 3)
                {
                    File = 7 - File;
                }

                if (AllPieceLists[i].IsWhitePieceList == true)
                {
                    Rank = 7 - Rank;

                    // for highly compressed tables
                    // int PositionValue = PieceTables[PieceType - 1, (Rank - (Rank % 2)) + (isCenter ? 1 : 0)];

                    //for half tables
                    int PositionValue = PieceTables[PieceType - 1, (Rank - (Rank % 4)) + (File)];

                    score += (int)PieceValues[PieceType] + PositionValue;
                }
                else
                {
                    // for highly compressed tables
                    // int PositionValue = PieceTables[PieceType - 1, (Rank - (Rank % 2)) + (isCenter ? 1 : 0)];

                    // for half tables
                    int PositionValue = PieceTables[PieceType - 1, (Rank - (Rank % 4)) + (File)];

                    score -= (int)PieceValues[PieceType] + PositionValue;
                }
            }
        }
        return score;
    }

    public int Minimax(Board board, int depth, bool isCurrentlyWhite, int alpha = -99999, int beta = 99999)
    {
        if (board.IsInCheckmate())
        {
            if (board.IsWhiteToMove)
            {
                return -99999;
            }
            else
            {
                return 99999;
            }
        } 
        else if (board.IsDraw())
        {
            return 0;
        }
        else if (depth == 0)
        {
            return EvaluatePosition(board);
        }

        Move[] Moves = board.GetLegalMoves();
        Move BestMove = Moves[0];

        int BestScore = -99999;
        if (isCurrentlyWhite == false)
        {
            BestScore = 99999;
        }

        for (int i = 0; i < Moves.Length; i++)
        {
            board.MakeMove(Moves[i]);
            int score = Minimax(board, depth - 1, !isCurrentlyWhite, alpha, beta);
            if (((score > BestScore) && (isCurrentlyWhite)) || ((score < BestScore) && (!isCurrentlyWhite)))
            {
                BestScore = score;
                BestMove = Moves[i];
            }
            board.UndoMove(Moves[i]);
            if (isCurrentlyWhite)
            {
                alpha = Math.Max(alpha, score);
            }
            else
            {
                beta = Math.Min(beta, score);
            }
            if (beta <= alpha)
            {
                break;
            }
        }
        return BestScore;
    }

    public Move Think(Board board, Timer timer)
    {
        int Depth = timer.MillisecondsRemaining > 20000 ? 6 : 3;

        Move[] moves = board.GetLegalMoves();
        int BestScore = board.IsWhiteToMove ? -99999 : 99999;
        Move BestMove = moves[0];

        for (int i = 0; i < moves.Length; i++)
        {
            board.MakeMove(moves[i]);

            int score = Minimax(board, Depth, board.IsWhiteToMove);

            board.UndoMove(moves[i]);

            if ((score > BestScore && board.IsWhiteToMove) || (score < BestScore && !board.IsWhiteToMove))
            {
                BestScore = score;
                BestMove = moves[i];
            }
        }
        return BestMove;
    }
}