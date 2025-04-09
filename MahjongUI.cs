using ImGuiNET;
using System;

namespace MahjongMaster {
    public class MahjongUI {
        public static void Draw(string[] hand) {
            ImGui.Begin("Mahjong Master");
            ImGui.Text("Hand: " + string.Join(" ", hand));
            ImGui.Text("Suggested discard: " + MahjongAnalyzer.SuggestDiscard(hand));
            ImGui.End();
        }
    }
}
