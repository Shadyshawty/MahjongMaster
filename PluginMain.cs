using Dalamud.Plugin;
using ImGuiNET;

namespace MahjongMaster {
    public class Plugin : IDalamudPlugin {
        public string Name => "Mahjong Master";

        public void Dispose() {}

        public void DrawUI() {
            ImGui.Begin("Mahjong Master");
            ImGui.Text("Suggested discard: Red Dragon");
            ImGui.End();
        }
    }
}
