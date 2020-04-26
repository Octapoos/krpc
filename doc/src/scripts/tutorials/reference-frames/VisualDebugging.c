#include <krpc_cnano.h>
#include <krpc_cnano/services/space_center.h>
#include <krpc_cnano/services/ui.h>
#include <krpc_cnano/services/drawing.h>

int main() {
  krpc_connection_t conn;
  krpc_open(&conn, "COM0");
  krpc_connect(conn, "Visual debugging");

  krpc_SpaceCenter_Vessel_t vessel;
  krpc_SpaceCenter_ActiveVessel(conn, &vessel);

  krpc_SpaceCenter_ReferenceFrame_t ref_frame;
  krpc_SpaceCenter_Vessel_SurfaceVelocityReferenceFrame(conn, &ref_frame, vessel);
  krpc_tuple_double_double_double_t direction = { 0, 1, 0 };
  krpc_Drawing_AddDirectionFromCom(conn, NULL, &direction, ref_frame, 10, true);
  while (true) {
  }
}
