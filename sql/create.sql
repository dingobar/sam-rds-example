create table vesselsignaldata (
    vesselimo integer NOT NULL,
    signal text NOT NULL,
    datetime timestamptz NOT NULL,
    value double precision NOT NULL,
    PRIMARY KEY(vesselimo, signal)
    );